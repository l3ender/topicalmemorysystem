using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Topical_Memory_System
{
	public partial class LearnVerses : UserControl
	{
		private static List<Verse> Verses;
		private static Verse CurrentVerse;
		private int CurrentVerseIndex;
		private int CurrentHintWordIndex;

		public LearnVerses(List<Verse> incomingVersesToReview)
		{
			InitializeComponent();
			VerseEntryBox.Focus();
			Verses = incomingVersesToReview;
			CurrentHintWordIndex = 0;
			CurrentVerseIndex = 0;
			CurrentVerse = Verses[CurrentVerseIndex];
			LoadVerse(CurrentVerse);
		}

		private static void LoadVerse(Verse v)
		{
			VerseLabel.Text = "Verse:  " + v.getReference();
		}

		private void CompareButton_Click(object sender, EventArgs e)
		{
			if (VerseEntryBox.Text.Length >= Constants.MinimumAllowedForMatching)
			{
				OriginalVerseBox.Text = CurrentVerse.getVerseData();
				MatchingBox.ResetText();
				HintButton.Enabled = false;

				string s1 = VerseEntryBox.Text;
				string s2 = CurrentVerse.getVerseData();

				if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
				{
					MatchingBox.Text = "Verse was 100% correct!  Congratulations!";
					RedLabel.Visible = false;
					GreenLabel.Visible = false;
				}
				else
				{
					ComparedString cs = Diff.DiffText(s1, s2);
					MatchingBox.Text = cs.FinalString;

					foreach (Selection s in cs.Selections)
					{
						MatchingBox.Select(s.Start, (s.End - s.Start));
						string text = MatchingBox.SelectedText;
						if (text.Equals(" "))
						{
							MatchingBox.SelectionBackColor = s.TextColor;
						}
						else
						{
							MatchingBox.SelectionColor = s.TextColor;
						}
						MatchingBox.SelectionFont = new Font(MatchingBox.SelectionFont, FontStyle.Bold);
					}
					RedLabel.Visible = true;
					GreenLabel.Visible = true;
				}
			}
			else
			{
				MessageBox.Show("Please enter at least some of the verse.  If you need help, hit the hint button!");
			}
		}

		private void EntryBoxEntered(object sender, EventArgs e)
		{
			if (VerseEntryBox.Text.Equals("Type the verse here"))
			{
				VerseEntryBox.Clear();
			}
		}

		private void KeyPressed(object sender, KeyPressEventArgs e)
		{
			CompareButton.Enabled = true;
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				CompareButton_Click(null, null);
			}
		}

		private void NextVerseButton_Click(object sender, EventArgs e)
		{
			CurrentVerseIndex++;
			if (CurrentVerseIndex == 1)
			{
				PreviousVerseButton.Enabled = true;
			}
			if (CurrentVerseIndex == (Verses.Count - 1))
			{
				NextVerseButton.Enabled = false;
			}
			CurrentVerse = Verses[CurrentVerseIndex];
			LoadVerse(CurrentVerse);
			ResetFields();
		}

		private void PreviousVerseButton_Click(object sender, EventArgs e)
		{
			CurrentVerseIndex--;
			if (CurrentVerseIndex == 0)
			{
				PreviousVerseButton.Enabled = false;
			}
			if (CurrentVerseIndex == (Verses.Count - 2))
			{
				NextVerseButton.Enabled = true;
			}
			CurrentVerse = Verses[CurrentVerseIndex];
			LoadVerse(CurrentVerse);
			ResetFields();
		}

		private void ResetFields()
		{
			VerseEntryBox.Text = "Type the verse here";
			OriginalVerseBox.Clear();
			MatchingBox.Clear();
			CompareButton.Enabled = false;
			RedLabel.Visible = false;
			GreenLabel.Visible = false;
			HintButton.Enabled = true;
			CurrentHintWordIndex = 0;
			BlankLabel.Focus();
		}

		public static void ChangeTranslation(string translation)
		{
			foreach (Verse v in Verses)
			{
				v.setTranslation(translation);
			}
			CurrentVerse.setTranslation(translation);
			LoadVerse(CurrentVerse);
		}

		private void HintButton_Click(object sender, EventArgs e)
		{
			string[] words = CurrentVerse.getVerseData().Split(' ');
			OriginalVerseBox.Text += words[CurrentHintWordIndex++] + " ";
			if (CurrentHintWordIndex >= CurrentVerse.getVerseData().Split(' ').Length)
			{
				HintButton.Enabled = false;
			}
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			ResetFields();
		}

	}
}
