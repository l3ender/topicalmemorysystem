using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Speech.Synthesis;

namespace Topical_Memory_System
{
	public partial class ViewVerses : UserControl
	{
		private static List<VersePack> Verses;
		private static VersePack SelectedVersePack;
		private static Verse SelectedVerse;

		public ViewVerses(List<VersePack> IncomingVerses)
		{
			InitializeComponent();
			Verses = IncomingVerses;
			VersePacksBox.Items.Clear();
			foreach (VersePack vp in Verses)
			{
				VersePacksBox.Items.Add(vp.Name);
			}
			if (!MenuExit.VoiceAvailable())
			{
				HearVerseButton.Enabled = false;
				HearVerseButton.Visible = false;
			}
		}

		private static void PackSelected(object sender, EventArgs e)
		{
			if (VersePacksBox.SelectedIndex > -1)
			{
				foreach (VersePack vp in Verses)
				{
					if (vp.Name == (string)VersePacksBox.SelectedItem)
					{
						SelectedVersePack = vp;
						VersesBox.Items.Clear();
						foreach (Verse v in vp.Verses)
						{
							VersesBox.Items.Add(v.getReference());
						}
						break;
					}
				}
				ViewInContextButton.Enabled = false;
				HearVerseButton.Enabled = false;
				VerseDataBox.Clear();
			}
		}

		private static void VerseSelected(object sender, EventArgs e)
		{
			if (VersePacksBox.SelectedIndex > -1)
			{
				foreach (Verse v in SelectedVersePack.Verses)
				{
					if (v.getReference() == (string)VersesBox.SelectedItem)
					{
						VerseDataBox.Text = v.getVerseData();
						SelectedVerse = v;
						ViewInContextButton.Enabled = true;
						HearVerseButton.Enabled = true;
						break;
					}
				}
			}
		}

		private void Refocus(object sender, EventArgs e)
		{
			BlankLabel.Focus();
		}

		public static void ChangeTranslation(string translation)
		{
			foreach (VersePack vp in Verses)
			{
				foreach (Verse v in vp.Verses)
				{
					v.setTranslation(translation);
				}
			}
			int selectedVerse = VersesBox.SelectedIndex;
			VersesBox.Items.Clear();
			PackSelected(null, null);
			VersesBox.SelectedIndex = selectedVerse;
		}

		private void ViewInContextButton_Click(object sender, EventArgs e)
		{
            MenuExit.ViewVerseInContext(SelectedVerse, MenuExit.SelectedTranslationName());
		}

		private string speakReference;
		private string speakVerse;

		private void HearVerseButton_Click(object sender, EventArgs e)
		{
			string verseReference = SelectedVerse.getBook() + ", " + Convert.ToString(SelectedVerse.getChapter() + " ");
			if (SelectedVerse.getVerseNumbers().Contains(','))
			{
				string[] numbers = SelectedVerse.getVerseNumbers().Split(',');
				verseReference += numbers[0] + " and " + numbers[1];
			}
			else
			{
				verseReference += SelectedVerse.getVerseNumbers();
			}
			speakReference = verseReference;
			speakVerse = SelectedVerse.getVerseData();
			MenuExit.TextToSpeech(speakReference + ".  " + speakVerse, MenuExit.SelectedVoiceName, MenuExit.SelectedVoiceSpeed);
			Refocus(null, null);
		}
	}
}
