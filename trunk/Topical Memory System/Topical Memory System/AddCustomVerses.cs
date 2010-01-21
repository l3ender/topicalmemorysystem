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
			this.CustomGroupNames = IncomingCustomGroupNames;
            InitializeComponent();
            UpdateGroupNames(null, null);
        }

        private void UpdateGroupNames(object sender, EventArgs e)
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
				string verseData = verseDataBox.Text.Trim().Replace("'", "''");
				string groupName = groupNames.Text;
				SaveVerseToDatabase(book, chapter, verseNumbers, verseData, groupName);
				groupNames.SelectedIndex = 0;
				bookBox.Text = "";
				referenceBox.Text = "";
				verseDataBox.Text = "";
			}
        }

		private void SaveVerseToDatabase(string book, int chapter, string verseNumbers, string verseData, string groupName)
		{
			SQLiteConnection conn;
			SQLiteCommand cmd;

			//set up connection
			conn = new SQLiteConnection(Constants.DatabaseConnectionString);
			conn.Open();
			cmd = conn.CreateCommand();

			//insert statement
			cmd.CommandText = "INSERT INTO CustomVerses (Book, Chapter, VerseNumbers, VerseData, GroupNameID) VALUES (" +
				"'" + book + "', " + chapter.ToString() + ", '" + verseNumbers + "', '" + verseData + "', " +
				"(SELECT ID FROM CustomGroups WHERE (Name  = '" + groupName + "') LIMIT 0, 1));";

			int result = cmd.ExecuteNonQuery();
			MessageBox.Show("Verse saved!");

			conn.Close();
		}
    }
}
