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

namespace Topical_Memory_System
{
	public partial class ReviewVerses : UserControl
	{
		private List<Verse> verses;
		private string translationText;
		private Hashtable topics;
		private int currentVerseIndex;
		private bool frontOfCard;

		public ReviewVerses(List<Verse> incomingVerses, string translation, Hashtable topics)
		{
			InitializeComponent();
			this.translationText = translation;
			this.topics = topics;
			frontOfCard = true;
			verses = new List<Verse>(incomingVerses.Count);
			Random r = new Random();
			while (incomingVerses.Count > 0)
			{
				int random = r.Next(incomingVerses.Count);
				verses.Add(incomingVerses[random]);
				incomingVerses.RemoveAt(random);
			}
			currentVerseIndex = 0;

			this.theme.Enabled = false;
			this.theme.Visible = false;
			this.reference.Enabled = false;
			this.reference.Visible = false;
			this.translation.Enabled = false;
			this.translation.Visible = false;
			this.verseData.Enabled = false;
			this.verseData.Visible = false;
			this.packInformation.Enabled = false;
			this.packInformation.Visible = false;
			this.hearButton.Enabled = false;
			this.hearButton.Visible = false;

			this.frontReference.Enabled = true;
			this.frontReference.Visible = true;

			this.previousVerseButton.Enabled = false;

			Verse v = verses[currentVerseIndex];
			setVerseFields(GetVerseTheme(v), v.getReference(), translationText, v.getVerseData(), v.getPackLetter() + "-" + v.getPackNumber() + "  " + GetPackTheme(v));
		}

		private void setVerseFields(string theme, string reference, string translation, string verseData, string packInformation)
		{
			this.theme.Text = theme;
			this.reference.Text = reference;
			this.translation.Text = translation;
			this.verseData.Text = Constants.TAB + verseData;
			this.packInformation.Text = packInformation;
			this.frontReference.Text = reference;
		}

		private void hearButton_Click(object sender, EventArgs e)
		{
			SpeechSynthesizer speaker = new SpeechSynthesizer();
			speaker.Rate = -2;
			speaker.Volume = 100;
			speaker.Speak(verses[currentVerseIndex].getReference());
			speaker.Speak(verses[currentVerseIndex].getVerseData());
		}

		private void flipButton_Click(object sender, EventArgs e)
		{
			if (frontOfCard)
			{
				this.theme.Enabled = true;
				this.theme.Visible = true;
				this.reference.Enabled = true;
				this.reference.Visible = true;
				this.translation.Enabled = true;
				this.translation.Visible = true;
				this.verseData.Enabled = true;
				this.verseData.Visible = true;
				this.packInformation.Enabled = true;
				this.packInformation.Visible = true;
				this.hearButton.Enabled = true;
				this.hearButton.Visible = true;

				this.frontReference.Enabled = false;
				this.frontReference.Visible = false;
			}
			else
			{
				this.theme.Enabled = false;
				this.theme.Visible = false;
				this.reference.Enabled = false;
				this.reference.Visible = false;
				this.translation.Enabled = false;
				this.translation.Visible = false;
				this.verseData.Enabled = false;
				this.verseData.Visible = false;
				this.packInformation.Enabled = false;
				this.packInformation.Visible = false;
				this.hearButton.Enabled = false;
				this.hearButton.Visible = false;

				this.frontReference.Enabled = true;
				this.frontReference.Visible = true;
			}
			//flip
			frontOfCard = !frontOfCard;
		}

		private void nextVerseButton_Click(object sender, EventArgs e)
		{
			currentVerseIndex++;
			if (currentVerseIndex == 1)
			{
				previousVerseButton.Enabled = true;
			}
			else if (currentVerseIndex == (verses.Count - 1))
			{
				nextVerseButton.Enabled = false;
			}
			Verse v = verses[currentVerseIndex];
			setVerseFields(GetVerseTheme(v), v.getReference(), translationText, v.getVerseData(), v.getPackLetter() + "-" + v.getPackNumber() + "  " + GetPackTheme(v));
		}

		private void previousVerseButton_Click(object sender, EventArgs e)
		{
			currentVerseIndex--;
			if (currentVerseIndex == 0)
			{
				previousVerseButton.Enabled = false;
			}
			else if (currentVerseIndex == (verses.Count - 2))
			{
				nextVerseButton.Enabled = true;
			}
			Verse v = verses[currentVerseIndex];
			setVerseFields(GetVerseTheme(v), v.getReference(), translationText, v.getVerseData(), v.getPackLetter() + "-" + v.getPackNumber() + "  " + GetPackTheme(v));
		}

		private string GetVerseTheme(Verse v)
		{
			int mainThemeIndex = 0;
			if (v.getPackLetter().Equals("A"))
			{
				mainThemeIndex = 1;
			}
			else if (v.getPackLetter().Equals("B"))
			{
				mainThemeIndex = 2;
			}
			else if (v.getPackLetter().Equals("C"))
			{
				mainThemeIndex = 3;
			}
			else if (v.getPackLetter().Equals("D"))
			{
				mainThemeIndex = 4;
			}
			else if (v.getPackLetter().Equals("E"))
			{
				mainThemeIndex = 5;
			}
			int verseThemeIndex = 0;
			if ((v.getPackNumber() % 2) != 0)	//if odd
			{
				verseThemeIndex = (v.getPackNumber() + 1) / 2;
			}
			else
			{
				verseThemeIndex = v.getPackNumber() / 2;
			}
			return ((string)((Hashtable)topics[mainThemeIndex])[verseThemeIndex]);
		}

		private string GetPackTheme(Verse v)
		{
			int mainThemeIndex = 0;
			if (v.getPackLetter().Equals("A"))
			{
				mainThemeIndex = 1;
			}
			else if (v.getPackLetter().Equals("B"))
			{
				mainThemeIndex = 2;
			}
			else if (v.getPackLetter().Equals("C"))
			{
				mainThemeIndex = 3;
			}
			else if (v.getPackLetter().Equals("D"))
			{
				mainThemeIndex = 4;
			}
			else if (v.getPackLetter().Equals("E"))
			{
				mainThemeIndex = 5;
			}
			return ((string)((Hashtable)topics[mainThemeIndex])[0]);
		}
	}
}
