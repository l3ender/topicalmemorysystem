using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Speech.Synthesis;
using System.Collections;
using System.Threading;

namespace Topical_Memory_System
{
	public partial class ReviewVerses : UserControl
	{
		private static List<Verse> verses;
		private string translationText;
		private static int currentVerseIndex;
		private bool frontOfCard;

		public ReviewVerses(List<Verse> incomingVerses, string incomingTranslation)
		{
			InitializeComponent();
            if (incomingVerses.Count == 1)
            {
                nextVerseButton.Enabled = false;
            }
			this.translationText = incomingTranslation;
			frontOfCard = true;
			verses = new List<Verse>(incomingVerses.Count);
			foreach (Verse verse in incomingVerses)
			{
				verses.Add(verse);
			}
			currentVerseIndex = 0;

			theme.Enabled = false;
			theme.Visible = false;
			reference.Enabled = false;
			reference.Visible = false;
			translation.Enabled = false;
			translation.Visible = false;
			verseData.Enabled = false;
			verseData.Visible = false;
			packInformation.Enabled = false;
			packInformation.Visible = false;
			this.hearButton.Enabled = false;
			this.hearButton.Visible = false;

			frontReference.Enabled = true;
			frontReference.Visible = true;

			this.previousVerseButton.Enabled = false;

			Verse v = verses[currentVerseIndex];
			SetVerseFields(v.getTmsMainTopic(), v.getReference(), v.getTranslation(), v.getVerseData(), v.getPackInformation() + "  " + v.getTmsSubTopic(), v.isTmsVerse());
		}

		private static void SetVerseFields(string incomingTheme, string incomingReference, string incomingTranslation, string incomingVerseData, string incomingPackInformation, bool isTMS)
		{
			theme.Text = incomingTheme;
			reference.Text = incomingReference;
            if (isTMS)
            {
                translation.Text = incomingTranslation;
            }
            else
            {
                translation.Text = "";
            }
			verseData.Text = Constants.Tab + incomingVerseData;
			if (verseData.Text.Length > 320)
			{
				verseData.ScrollBars = ScrollBars.Vertical;
			}
			else
			{
				verseData.ScrollBars = ScrollBars.None;
			}
			packInformation.Text = incomingPackInformation;
			frontReference.Text = incomingReference;
		}

		private static string speakReference;
		private static string speakVerse;

		private void HearButton_Click(object sender, EventArgs e)
		{
            string verseReference = verses[currentVerseIndex].getBook() + ", " + Convert.ToString(verses[currentVerseIndex].getChapter() + " ");
            if (verses[currentVerseIndex].getVerseNumbers().Contains(','))
            {
                string[] numbers = verses[currentVerseIndex].getVerseNumbers().Split(',');
                verseReference += numbers[0] + " and " + numbers[1];
            }
            else
            {
                verseReference += verses[currentVerseIndex].getVerseNumbers();
            }
            speakReference = verseReference;
            speakVerse = verses[currentVerseIndex].getVerseData();
			MenuExit.TextToSpeech(speakReference + ".  " + speakVerse, MenuExit.SelectedVoiceName, MenuExit.SelectedVoiceSpeed);
            Unfocus(verseData, null);
		}

		private void FlipButton_Click(object sender, EventArgs e)
		{
			theme.Enabled = !theme.Enabled;
			theme.Visible = !theme.Visible;
			reference.Enabled = !reference.Enabled;
			reference.Visible = !reference.Visible;
			translation.Enabled = !translation.Enabled;
			translation.Visible = !translation.Visible;
			verseData.Enabled = !verseData.Enabled;
			verseData.Visible = !verseData.Visible;
			packInformation.Enabled = !packInformation.Enabled;
			packInformation.Visible = !packInformation.Visible;
			if (MenuExit.VoiceAvailable())
			{
				this.hearButton.Enabled = !this.hearButton.Enabled;
				this.hearButton.Visible = !this.hearButton.Visible;
			}
			this.viewVerseInContextButton.Enabled = !this.viewVerseInContextButton.Enabled;
			this.viewVerseInContextButton.Visible = !this.viewVerseInContextButton.Visible;

			frontReference.Enabled = !frontReference.Enabled;
			frontReference.Visible = !frontReference.Visible;

			//flip
			frontOfCard = !frontOfCard;
		}

		private void NextVerseButton_Click(object sender, EventArgs e)
		{
            Unfocus(frontReference, null);
			if (!frontOfCard)
			{
				FlipButton_Click(null, null);	//done so the person always sees the reference side first
			}
			currentVerseIndex++;
			if (currentVerseIndex == 1)
			{
				previousVerseButton.Enabled = true;
			}
			if (currentVerseIndex == (verses.Count - 1))
			{
				nextVerseButton.Enabled = false;
			}
			Verse v = verses[currentVerseIndex];
			SetVerseFields(v.getTmsMainTopic(), v.getReference(), v.getTranslation(), v.getVerseData(), v.getPackInformation() + "  " + v.getTmsSubTopic(), v.isTmsVerse());
		}

		private void PreviousVerseButton_Click(object sender, EventArgs e)
		{
            Unfocus(frontReference, null);
			if (!frontOfCard)
			{
				FlipButton_Click(null, null);	//done so the person always sees the reference side first
			}
			currentVerseIndex--;
			if (currentVerseIndex == 0)
			{
				previousVerseButton.Enabled = false;
			}
			if (currentVerseIndex == (verses.Count - 2))
			{
				nextVerseButton.Enabled = true;
			}
			Verse v = verses[currentVerseIndex];
			SetVerseFields(v.getTmsMainTopic(), v.getReference(), v.getTranslation(), v.getVerseData(), v.getPackInformation() + "  " + v.getTmsSubTopic(), v.isTmsVerse());
		}

		public static void ChangeTranslation(string translation)
		{
			foreach (Verse v in verses)
			{
				v.setTranslation(translation);
			}
			Verse verse = verses[currentVerseIndex];
			SetVerseFields(verse.getTmsMainTopic(), verse.getReference(), verse.getTranslation(), verse.getVerseData(), verse.getPackInformation() + "  " + verse.getTmsSubTopic(), verse.isTmsVerse());
		}

        private void ViewVerseInContextButton_Click(object sender, EventArgs e)
        {
            MenuExit.ViewVerseInContext(verses[currentVerseIndex], MenuExit.SelectedTranslationName());
        }

        private void MainUnfocus(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectionLength = 0;
            blankLabel.Focus();
        }

        private void Unfocus(object sender, MouseEventArgs e)
        {
            MainUnfocus(sender, null);
        }

	}
}
