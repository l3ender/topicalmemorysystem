using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Topical_Memory_System
{
    public partial class MatchVerses : UserControl
    {
		private static List<Verse> undeletableVersesToMatch;    //the ones we need to match - kept for multiple rounds
		private static List<Verse> versesToMatch;

		private static List<Verse> undeletableVersesToMatchAgainst;
		private static List<Verse> versesToMatchAgainst;

		private string translationText;
        private static bool verseToReference;

        private static Verse currentToMatch;
        private static List<Verse> currentMatching;				//a list of the five verses to put in the answer panes
        private static int correctMatch;

        private int totalVerses;
        private int correctAnswers;
        private int incorrectAnswers;
        private int versesLeft;
        private int incorrectAnswersForRound;

		private bool foundCorrectAnswer;

		private Random rNum;

        public MatchVerses(List<Verse> incomingVersesToMatch, string incomingTranslation, 
            bool incomingVerseToReference, List<Verse> incomingVersesToMatchAgainst)
        {
            InitializeComponent();
			foundCorrectAnswer = false;
			rNum = new Random();
			totalVerses = incomingVersesToMatch.Count;
            correctAnswers = 0;
            incorrectAnswers = 0;
            incorrectAnswersForRound = 0;
			versesLeft = incomingVersesToMatch.Count - 1;
            versesLeftLabel.Text = versesLeft.ToString() + " verses left";
            nextVerseButton.Enabled = false;
			undeletableVersesToMatch = new List<Verse>(incomingVersesToMatch.Count);
			versesToMatch = new List<Verse>(incomingVersesToMatch.Count);
			undeletableVersesToMatchAgainst = new List<Verse>(incomingVersesToMatchAgainst.Count);
			versesToMatchAgainst = new List<Verse>(incomingVersesToMatchAgainst.Count);
			foreach (Verse v in incomingVersesToMatch)
			{
				undeletableVersesToMatch.Add(v);
				versesToMatch.Add(v);
			}
			foreach (Verse v in incomingVersesToMatchAgainst)
			{
				undeletableVersesToMatchAgainst.Add(v);
				versesToMatchAgainst.Add(v);
			}
            this.translationText = incomingTranslation;
            verseToReference = incomingVerseToReference;

            currentMatching = new List<Verse>(4);
            correctMatch = -1;
            SetFields(verseToReference);
        }

        private void SetFields(bool verseToReference)
        {
            currentMatching.Clear();
			currentToMatch = versesToMatch[0];
			versesToMatch.RemoveAt(0);
            nextVerseButton.Enabled = false;

			//try first to match using verses that are in the same pack (also being matched against)
			if (versesToMatch.Count > 0)
			{
				foreach (Verse v in versesToMatch)
				{
					currentMatching.Add(v);
					if (currentMatching.Count == 4)		//have all the matches we need
					{
						break;
					}
				}
			}
			while (currentMatching.Count < 4)
			{
				int rand = rNum.Next(versesToMatchAgainst.Count);
				if (!currentMatching.Contains(versesToMatchAgainst[rand]) && !versesToMatchAgainst[rand].Equals(currentToMatch))
				{
					currentMatching.Add(versesToMatchAgainst[rand]);
					versesToMatchAgainst.RemoveAt(rand);
					if (versesToMatchAgainst.Count == 0)
					{
						foreach (Verse v in undeletableVersesToMatchAgainst)
						{
							versesToMatchAgainst.Add(v);
						}
					}
				}
			}
			correctMatch = rNum.Next(5) + 1; //returns numbers 1-5
			DisplayVerses();
        }

		private static void DisplayVerses()
        {
            if (verseToReference)
            {
                toMatchBox.Text = currentToMatch.getVerseData();
				if (correctMatch == 1)
                {
                    match1.Text = currentToMatch.getReference();
                    match2.Text = currentMatching[0].getReference();
                    match3.Text = currentMatching[1].getReference();
                    match4.Text = currentMatching[2].getReference();
                    match5.Text = currentMatching[3].getReference();
                }
				else if (correctMatch == 2)
                {
                    match2.Text = currentToMatch.getReference();
                    match1.Text = currentMatching[0].getReference();
                    match3.Text = currentMatching[1].getReference();
                    match4.Text = currentMatching[2].getReference();
                    match5.Text = currentMatching[3].getReference();
                }
				else if (correctMatch == 3)
                {
                    match3.Text = currentToMatch.getReference();
                    match1.Text = currentMatching[0].getReference();
                    match2.Text = currentMatching[1].getReference();
                    match4.Text = currentMatching[2].getReference();
                    match5.Text = currentMatching[3].getReference();
                }
				else if (correctMatch == 4)
                {
                    match4.Text = currentToMatch.getReference();
                    match1.Text = currentMatching[0].getReference();
                    match2.Text = currentMatching[1].getReference();
                    match3.Text = currentMatching[2].getReference();
                    match5.Text = currentMatching[3].getReference();
                }
				else if (correctMatch == 5)
                {
                    match5.Text = currentToMatch.getReference();
                    match1.Text = currentMatching[0].getReference();
                    match2.Text = currentMatching[1].getReference();
                    match3.Text = currentMatching[2].getReference();
                    match4.Text = currentMatching[3].getReference();
                }
            }
            else
            {
                toMatchBox.Text = currentToMatch.getReference();
				if (correctMatch == 1)
                {
                    match1.Text = currentToMatch.getVerseData();
                    match2.Text = currentMatching[0].getVerseData();
                    match3.Text = currentMatching[1].getVerseData();
                    match4.Text = currentMatching[2].getVerseData();
                    match5.Text = currentMatching[3].getVerseData();
                }
				else if (correctMatch == 2)
                {
                    match2.Text = currentToMatch.getVerseData();
                    match1.Text = currentMatching[0].getVerseData();
                    match3.Text = currentMatching[1].getVerseData();
                    match4.Text = currentMatching[2].getVerseData();
                    match5.Text = currentMatching[3].getVerseData();
                }
				else if (correctMatch == 3)
                {
                    match3.Text = currentToMatch.getVerseData();
                    match1.Text = currentMatching[0].getVerseData();
                    match2.Text = currentMatching[1].getVerseData();
                    match4.Text = currentMatching[2].getVerseData();
                    match5.Text = currentMatching[3].getVerseData();
                }
				else if (correctMatch == 4)
                {
                    match4.Text = currentToMatch.getVerseData();
                    match1.Text = currentMatching[0].getVerseData();
                    match2.Text = currentMatching[1].getVerseData();
                    match3.Text = currentMatching[2].getVerseData();
                    match5.Text = currentMatching[3].getVerseData();
                }
				else if (correctMatch == 5)
                {
                    match5.Text = currentToMatch.getVerseData();
                    match1.Text = currentMatching[0].getVerseData();
                    match2.Text = currentMatching[1].getVerseData();
                    match3.Text = currentMatching[2].getVerseData();
                    match4.Text = currentMatching[3].getVerseData();
                }
            }
        }

        private void BoxSelected(object sender, EventArgs e)
        {
			if (!viewStatsButton.Visible && !foundCorrectAnswer)
            {
                int choice = Convert.ToInt32(((TextBox)sender).Name.ToString().Replace("match", ""));
                if (((TextBox)sender).BackColor.Equals(System.Drawing.SystemColors.Control))
                {   //only update stats if the button hasn't been clicked before
                    if (choice == correctMatch)
                    {
                        if (incorrectAnswersForRound == 0)
                        {
                            correctAnswers++;
                        }
                    }
                    else
                    {
                        incorrectAnswers++;
                        incorrectAnswersForRound++; ;
                    }
                }
                if (choice == correctMatch)
                {
					foundCorrectAnswer = true;
                    ((TextBox)sender).BackColor = Color.FromArgb(51, 221, 51);
                    if (versesLeft > 0)
                    {
                        nextVerseButton.Enabled = true;
                    }
                    else
                    {
                        viewStatsButton.Visible = true;
                        viewStatsButton.Enabled = true;
                        restartButton.Visible = true;
                        restartButton.Enabled = true;
                    }
                }
                else
                {
                    ((TextBox)sender).BackColor = Color.FromArgb(225, 50, 30);
                }
            }
        }

        private void NextVerseButton_Click(object sender, EventArgs e)
        {
            blankLabel.Focus();
            versesLeft--;
            incorrectAnswersForRound = 0;
            versesLeftLabel.Text = versesLeft.ToString() + " verses left";
            match1.BackColor = System.Drawing.SystemColors.Control;
            match2.BackColor = System.Drawing.SystemColors.Control;
            match3.BackColor = System.Drawing.SystemColors.Control;
            match4.BackColor = System.Drawing.SystemColors.Control;
            match5.BackColor = System.Drawing.SystemColors.Control;
			foundCorrectAnswer = false;
            SetFields(verseToReference);
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

        private void ViewStatsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected the correct answer on your first try " + correctAnswers.ToString() + " out of " + totalVerses.ToString() + " times.\r\n" +
                "You selected a wrong answer " + incorrectAnswers.ToString() + " times.");
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            blankLabel.Focus();
			foundCorrectAnswer = false;
            match1.BackColor = System.Drawing.SystemColors.Control;
            match2.BackColor = System.Drawing.SystemColors.Control;
            match3.BackColor = System.Drawing.SystemColors.Control;
            match4.BackColor = System.Drawing.SystemColors.Control;
            match5.BackColor = System.Drawing.SystemColors.Control;
            nextVerseButton.Enabled = false;
            viewStatsButton.Enabled = false;
            viewStatsButton.Visible = false;
            restartButton.Enabled = false;
            restartButton.Visible = false;
			totalVerses = undeletableVersesToMatch.Count;
			correctAnswers = 0;
			incorrectAnswers = 0;
			incorrectAnswersForRound = 0;
			versesLeft = undeletableVersesToMatch.Count - 1;
			versesLeftLabel.Text = versesLeft.ToString() + " verses left";
			nextVerseButton.Enabled = false;

			foreach (Verse v in undeletableVersesToMatch)
			{
				versesToMatch.Add(v);
			}
			foreach (Verse v in undeletableVersesToMatchAgainst)
			{
				versesToMatchAgainst.Add(v);
			}
			currentMatching.Clear();
			correctMatch = -1;
			SetFields(verseToReference);
        }

        public static void ChangeTranslation(string translation)
        {
            foreach (Verse v in undeletableVersesToMatch)
            {
                v.setTranslation(translation);
            }
            foreach (Verse v in versesToMatch)
            {
                v.setTranslation(translation);
            }
			foreach (Verse v in undeletableVersesToMatchAgainst)
			{
				v.setTranslation(translation);
			}
			foreach (Verse v in versesToMatchAgainst)
			{
				v.setTranslation(translation);
			}
            DisplayVerses();
        }
    }
}
