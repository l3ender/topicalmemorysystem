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
	public partial class LearnReferences : UserControl
	{
		private static List<Verse> versesToReview;
		private int currentVerseIndex;
		private static Verse currentVerse;

		public LearnReferences(List<Verse> incomingVersesToReview)
		{
			InitializeComponent();
			List<string> books = Constants.BooksOfTheBible();
			foreach (string book in books)
			{
				BookBox.AutoCompleteCustomSource.Add(book);
				BookBox.Items.Add(book);
			}
			if (incomingVersesToReview.Count == 1)
			{
				NextVerseButton.Enabled = false;
			}
			versesToReview = incomingVersesToReview;
			currentVerseIndex = 0;
			currentVerse = versesToReview[currentVerseIndex];
			VerseBox.Text = currentVerse.getVerseData();
		}

		private void GuessButton_Click(object sender, EventArgs e)
		{
			if (!ReferenceBox.Text.Contains(':'))
			{
				MessageBox.Show("Please enter the reference in the correct format (example: 15:3 or 15:3,4)");
			}
			else if (!IsNumber(ReferenceBox.Text.Split(':')[0]))
			{
				MessageBox.Show("Invalid reference.  Please enter in the given format (15:3 or 15:3,4).");
			}
			else
			{
				//compare book
				BookAnswerLabel1.Visible = true;
				BookAnswerLabel2.Visible = true;
				if (currentVerse.getBook() == BookBox.Text)
				{
					BookAnswerLabel2.Text = "Correct";
					BookAnswerLabel2.ForeColor = Color.Green;
				}
				else
				{
					BookAnswerLabel2.Text = "Incorrect";
					BookAnswerLabel2.ForeColor = Color.Red;
				}

				//compare chapter
				ChapterAnswerLabel1.Visible = true;
				ChapterAnswerLabel2.Visible = true;
				if (currentVerse.getChapter() == Convert.ToInt32(ReferenceBox.Text.Split(':')[0]))
				{
					ChapterAnswerLabel2.Text = "Correct";
					ChapterAnswerLabel2.ForeColor = Color.Green;
				}
				else
				{
					ChapterAnswerLabel2.Text = "Incorrect";
					ChapterAnswerLabel2.ForeColor = Color.Red;
				}

				//compare verses
				VerseAnswerLabel1.Visible = true;
				VerseAnswerLabel2.Visible = true;
				if (currentVerse.getVerseNumbers() == ReferenceBox.Text.Split(':')[1])
				{
					VerseAnswerLabel2.Text = "Correct";
					VerseAnswerLabel2.ForeColor = Color.Green;
				}
				else
				{
					VerseAnswerLabel2.Text = "Incorrect";
					VerseAnswerLabel2.ForeColor = Color.Red;
				}
			}
		}

		private bool IsNumber(string s)
		{
			try
			{
				double num;
				Double.TryParse(s, out num);
				Convert.ToInt32(s);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		private void PreviousVerseButton_Click(object sender, EventArgs e)
		{
			ResetFields();
			currentVerseIndex--;
			if (currentVerseIndex == 0)
			{
				PreviousVerseButton.Enabled = false;
			}
			if (currentVerseIndex == (versesToReview.Count - 2))
			{
				NextVerseButton.Enabled = true;
			}
			currentVerse = versesToReview[currentVerseIndex];
			VerseBox.Text = currentVerse.getVerseData();
		}

		private void NextVerseButton_Click(object sender, EventArgs e)
		{
			ResetFields();
			currentVerseIndex++;
			if (currentVerseIndex == 1)
			{
				PreviousVerseButton.Enabled = true;
			}
			if (currentVerseIndex == (versesToReview.Count - 1))
			{
				NextVerseButton.Enabled = false;
			}
			currentVerse = versesToReview[currentVerseIndex];
			VerseBox.Text = currentVerse.getVerseData();
		}

		private void ResetFields()
		{
			BookBox.SelectedIndex = -1;
			ReferenceBox.Text = "";
			BookBox.Focus();
			BookAnswerLabel1.Visible = false;
			BookAnswerLabel2.Visible = false;
			ChapterAnswerLabel1.Visible = false;
			ChapterAnswerLabel2.Visible = false;
			VerseAnswerLabel1.Visible = false;
			VerseAnswerLabel2.Visible = false;
		}

		private void ReferenceKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				GuessButton_Click(null, null);
			}
		}

		private void PanelLoad(object sender, EventArgs e)
		{
			BookBox.Focus();
		}

		public static void ChangeTranslation(string translation)
		{
			foreach (Verse v in versesToReview)
			{
				v.setTranslation(translation);
			}
			currentVerse.setTranslation(translation);
			//reload dropdown for books of the bible
			BookBox.AutoCompleteCustomSource.Clear();
			BookBox.Items.Clear();
			if (translation == "NBV")
			{
				List<string> books = Constants.DutchBooksOfTheBible();
				foreach (string book in books)
				{
					BookBox.AutoCompleteCustomSource.Add(book);
					BookBox.Items.Add(book);
				}
			}
			else
			{
				List<string> books = Constants.BooksOfTheBible();
				foreach (string book in books)
				{
					BookBox.AutoCompleteCustomSource.Add(book);
					BookBox.Items.Add(book);
				}
			}
			VerseBox.Text = currentVerse.getVerseData();
		}
	}
}
