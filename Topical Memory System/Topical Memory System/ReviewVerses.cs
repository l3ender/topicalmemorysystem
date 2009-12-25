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
		private static Hashtable topics;
		private static int currentVerseIndex;
		private bool frontOfCard;

		public ReviewVerses(List<Verse> incomingVerses, string incomingTranslation, Hashtable incomingTopics)
		{
			InitializeComponent();
			this.translationText = incomingTranslation;
			topics = incomingTopics;
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
			SetVerseFields(GetVerseTheme(v), v.getReference(), v.getTranslation(), v.getVerseData(), v.getPackLetter() + "-" + v.getPackNumber() + "  " + GetPackTheme(v));
		}

		private static void SetVerseFields(string incomingTheme, string incomingReference, string incomingTranslation, string incomingVerseData, string incomingPackInformation)
		{
			theme.Text = incomingTheme;
			reference.Text = incomingReference;
			translation.Text = incomingTranslation;
			verseData.Text = Constants.TAB + incomingVerseData;
			packInformation.Text = incomingPackInformation;
			frontReference.Text = incomingReference;
		}

		private void HearButton_Click(object sender, EventArgs e)
		{
            if (!isReading)
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
                Thread t = new Thread(SayVerse);
                t.Start();
            }
            Unfocus(verseData, null);
		}

        private static string speakReference;
        private static string speakVerse;
        private static bool isReading;

        private static void SayVerse()
        {
            isReading = true;
            SpeechSynthesizer speaker = new SpeechSynthesizer();
            bool canRead = false;
            try
            {
                speaker.SelectVoice(MenuExit.SelectedVoiceName());
                canRead = true;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Text to speech is not supported on this computer.");
                e.ToString();
            }
            if (canRead)
            {
                speaker.Rate = -2;
                speaker.Volume = 100;
                speaker.Speak(speakReference);
                speaker.Speak(speakVerse);
            }
            isReading = false;
        }

		private void FlipButton_Click(object sender, EventArgs e)
		{
			if (frontOfCard)
			{
				theme.Enabled = true;
				theme.Visible = true;
				reference.Enabled = true;
				reference.Visible = true;
				translation.Enabled = true;
				translation.Visible = true;
				verseData.Enabled = true;
				verseData.Visible = true;
				packInformation.Enabled = true;
				packInformation.Visible = true;
				this.hearButton.Enabled = true;
				this.hearButton.Visible = true;
                this.viewVerseInContextButton.Enabled = true;
                this.viewVerseInContextButton.Visible = true;

				frontReference.Enabled = false;
				frontReference.Visible = false;
			}
			else
			{
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
                this.viewVerseInContextButton.Enabled = false;
                this.viewVerseInContextButton.Visible = false;

				frontReference.Enabled = true;
				frontReference.Visible = true;
			}
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
			else if (currentVerseIndex == (verses.Count - 1))
			{
				nextVerseButton.Enabled = false;
			}
			Verse v = verses[currentVerseIndex];
			SetVerseFields(GetVerseTheme(v), v.getReference(), v.getTranslation(), v.getVerseData(), v.getPackLetter() + "-" + v.getPackNumber() + "  " + GetPackTheme(v));
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
			else if (currentVerseIndex == (verses.Count - 2))
			{
				nextVerseButton.Enabled = true;
			}
			Verse v = verses[currentVerseIndex];
			SetVerseFields(GetVerseTheme(v), v.getReference(), v.getTranslation(), v.getVerseData(), v.getPackLetter() + "-" + v.getPackNumber() + "  " + GetPackTheme(v));
		}

		private static string GetVerseTheme(Verse v)
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

		private static string GetPackTheme(Verse v)
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

		public static void ChangeTranslation(int translation)
		{
			foreach (Verse v in verses)
			{
				v.setTranslation(translation);
			}
			Verse verse = verses[currentVerseIndex];
			SetVerseFields(GetVerseTheme(verse), verse.getReference(), verse.getTranslation(), verse.getVerseData(), verse.getPackLetter() + "-" + verse.getPackNumber() + "  " + GetPackTheme(verse));
		}

        private void ViewVerseInContextButton_Click(object sender, EventArgs e)
        {
            MenuExit.ViewVerseInContext(verses[currentVerseIndex], translation.Text);
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
