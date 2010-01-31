using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data.SQLite;

namespace Topical_Memory_System
{
    public partial class AddCustomVerses : Form
    {

        private List<string> CustomGroupNames;

		public AddCustomVerses(List<string> IncomingCustomGroupNames)
        {
            InitializeComponent();
			this.CustomGroupNames = IncomingCustomGroupNames;
			if (this.CustomGroupNames.Count == 0)
			{
				throw new Exception();
			}
            UpdateGroupNames();
        }

        private void UpdateGroupNames()
        {
            groupNames.Items.Clear();
			foreach (string name in CustomGroupNames)
            {
				groupNames.Items.Add(name);
            }
			groupNames.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
			bool okay = true;
			if (bookBox.Text.Trim() == "" || referenceBox.Text.Trim() == "" || verseDataBox.Text.Trim() == "")
			{
				MessageBox.Show("You must enter the book, reference, and verse!");
				okay = false;
			}
			if (okay && !referenceBox.Text.Contains(':'))
			{
				MessageBox.Show("Please enter the reference in the correct form.  Example:  15:3");
				okay = false;
			}
			if (okay)
			{
				string book = bookBox.Text.Trim();
				int chapter = Convert.ToInt32(referenceBox.Text.Split(':')[0].Trim());
				string verseNumbers = referenceBox.Text.Split(':')[1].Trim();
				string verseData = verseDataBox.Text.Trim();
				string groupName = groupNames.Text;
				SaveVerseToDatabase(book, chapter, verseNumbers, verseData, groupName);
				bookBox.Text = "";
				referenceBox.Text = "";
				verseDataBox.Text = "";
			}
        }

		private void SaveVerseToDatabase(string book, int chapter, string verseNumbers, string verseData, string groupName)
		{
			try
			{
				string newVerseData = verseData;
				if (verseData.Contains("\r\n"))
				{
					newVerseData = newVerseData.Replace("\r\n", " ");
				}
				else if (verseData.Contains("\n"))
				{
					newVerseData = newVerseData.Replace("\n", " ");
				}
				else if (verseData.Contains("\r"))
				{
					newVerseData = newVerseData.Replace("\r", " ");
				}
				MenuExit.SaveVerseToDatabase(book, chapter, verseNumbers, newVerseData, groupName);
				MessageBox.Show("Verse saved!");
			}
			catch (Exception)
			{
				MessageBox.Show("The verse was unable to be saved.");
			}
		}
    }
}
