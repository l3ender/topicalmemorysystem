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
        private static List<Verse> undeletableAllVerses;    //the ones we need to match - kept for multiple rounds
        private static List<Verse> allVerses;               //the ones we need to match
        private static List<Verse> verses;                  //the ones we match against
        private static List<Verse> undeletableVerses;
		private string translationText;
		private static Hashtable topics;
        private static bool verseToReference;

        private static Verse currentToMatch;
        private static List<Verse> currentMatching;
        private int correctMatch;
        private static int random;

        private int totalVerses;
        private int correctAnswers;
        private int incorrectAnswers;
        private int versesLeft;
        private int incorrectAnswersForRound;

        public MatchVerses(List<Verse> incomingVerses, string incomingTranslation, Hashtable incomingTopics, 
            bool incomingVerseToReference, List<Verse> incomingAllVerses, Hashtable customVerses)
        {
            InitializeComponent();
            totalVerses = incomingVerses.Count;
            correctAnswers = 0;
            incorrectAnswers = 0;
            incorrectAnswersForRound = 0;
            versesLeft = incomingVerses.Count - 1;
            versesLeftLabel.Text = versesLeft.ToString() + " verses left";
            nextVerseButton.Enabled = false;
            undeletableAllVerses = new List<Verse>(incomingVerses.Count);
            verses = new List<Verse>();
            undeletableVerses = new List<Verse>();
            allVerses = new List<Verse>(incomingVerses.Count);
            Random r = new Random();
            while (incomingVerses.Count > 0)
            {
                int random = r.Next(incomingVerses.Count);
                allVerses.Add(incomingVerses[random]);
                undeletableAllVerses.Add(incomingVerses[random]);
                incomingVerses.RemoveAt(random);
            }
            foreach (Verse v in incomingAllVerses)
            {
                verses.Add(v);
                undeletableVerses.Add(v);
            }
            foreach (DictionaryEntry obj in customVerses)
            {
                foreach (Verse v in ((List<Verse>)obj.Value))
                {
                    undeletableVerses.Add(v);
                }
            }
            this.translationText = incomingTranslation;
            topics = incomingTopics;
            verseToReference = incomingVerseToReference;

            currentMatching = new List<Verse>(5);
            correctMatch = -1;
            SetFields(verseToReference);
        }

        private void SetFields(bool verseToReference)
        {
            currentMatching.Clear();
            currentToMatch = allVerses[0];
            allVerses.RemoveAt(0);
            nextVerseButton.Enabled = false;
            Random rNum = new Random();
            bool done = false;
            int count = 0;
            while (!done)
            {
                int rand = rNum.Next(verses.Count);
                if (!currentMatching.Contains(verses[rand]) && !verses[rand].Equals(currentToMatch))
                {
                    currentMatching.Add(verses[rand]);
                    count++;
                    if (count == 4)
                    {
                        done = true;
                    }
                }
            }
            Random r = new Random();
            random = r.Next(5) + 1; //returns numbers 1-5
            correctMatch = random;
            DisplayVerses();
        }

        private static void DisplayVerses()
        {
            if (verseToReference)
            {
                toMatchBox.Text = currentToMatch.getVerseData();
                if (random == 1)
                {
                    match1.Text = currentToMatch.getReference();
                    match2.Text = currentMatching[0].getReference();
                    match3.Text = currentMatching[1].getReference();
                    match4.Text = currentMatching[2].getReference();
                    match5.Text = currentMatching[3].getReference();
                }
                else if (random == 2)
                {
                    match2.Text = currentToMatch.getReference();
                    match1.Text = currentMatching[0].getReference();
                    match3.Text = currentMatching[1].getReference();
                    match4.Text = currentMatching[2].getReference();
                    match5.Text = currentMatching[3].getReference();
                }
                else if (random == 3)
                {
                    match3.Text = currentToMatch.getReference();
                    match1.Text = currentMatching[0].getReference();
                    match2.Text = currentMatching[1].getReference();
                    match4.Text = currentMatching[2].getReference();
                    match5.Text = currentMatching[3].getReference();
                }
                else if (random == 4)
                {
                    match4.Text = currentToMatch.getReference();
                    match1.Text = currentMatching[0].getReference();
                    match2.Text = currentMatching[1].getReference();
                    match3.Text = currentMatching[2].getReference();
                    match5.Text = currentMatching[3].getReference();
                }
                else if (random == 5)
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
                if (random == 1)
                {
                    match1.Text = currentToMatch.getVerseData();
                    match2.Text = currentMatching[0].getVerseData();
                    match3.Text = currentMatching[1].getVerseData();
                    match4.Text = currentMatching[2].getVerseData();
                    match5.Text = currentMatching[3].getVerseData();
                }
                else if (random == 2)
                {
                    match2.Text = currentToMatch.getVerseData();
                    match1.Text = currentMatching[0].getVerseData();
                    match3.Text = currentMatching[1].getVerseData();
                    match4.Text = currentMatching[2].getVerseData();
                    match5.Text = currentMatching[3].getVerseData();
                }
                else if (random == 3)
                {
                    match3.Text = currentToMatch.getVerseData();
                    match1.Text = currentMatching[0].getVerseData();
                    match2.Text = currentMatching[1].getVerseData();
                    match4.Text = currentMatching[2].getVerseData();
                    match5.Text = currentMatching[3].getVerseData();
                }
                else if (random == 4)
                {
                    match4.Text = currentToMatch.getVerseData();
                    match1.Text = currentMatching[0].getVerseData();
                    match2.Text = currentMatching[1].getVerseData();
                    match3.Text = currentMatching[2].getVerseData();
                    match5.Text = currentMatching[3].getVerseData();
                }
                else if (random == 5)
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
            if (!viewStatsButton.Visible)
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
            match1.BackColor = System.Drawing.SystemColors.Control;
            match2.BackColor = System.Drawing.SystemColors.Control;
            match3.BackColor = System.Drawing.SystemColors.Control;
            match4.BackColor = System.Drawing.SystemColors.Control;
            match5.BackColor = System.Drawing.SystemColors.Control;
            List<Verse> incomingVerses = new List<Verse>();
            totalVerses = undeletableAllVerses.Count;
            verses.Clear();
            foreach (Verse v in undeletableAllVerses)
            {
                incomingVerses.Add(v);
            }
            correctAnswers = 0;
            incorrectAnswers = 0;
            incorrectAnswersForRound = 0;
            versesLeft = incomingVerses.Count - 1;
            versesLeftLabel.Text = versesLeft.ToString() + " verses left";
            nextVerseButton.Enabled = false;
            viewStatsButton.Enabled = false;
            viewStatsButton.Visible = false;
            restartButton.Enabled = false;
            restartButton.Visible = false;
            verses = new List<Verse>(incomingVerses.Count);
            allVerses = new List<Verse>(incomingVerses.Count);
            Random r = new Random();
            while (incomingVerses.Count > 0)
            {
                int random = r.Next(incomingVerses.Count);
                allVerses.Add(incomingVerses[random]);
                incomingVerses.RemoveAt(random);
            }
            foreach (Verse v in undeletableVerses)
            {
                verses.Add(v);
            }
            currentMatching = new List<Verse>(5);
            correctMatch = -1;
            SetFields(verseToReference);
        }

        public static void ChangeTranslation(string translation)
        {
            foreach (Verse v in undeletableAllVerses)
            {
                v.setTranslation(translation);
            }
            foreach (Verse v in allVerses)
            {
                v.setTranslation(translation);
            }
            foreach (Verse v in currentMatching)
            {
                v.setTranslation(translation);
            }
            foreach (Verse v in verses)
            {
                v.setTranslation(translation);
            }
            DisplayVerses();
        }
    }
}
