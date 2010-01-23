using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Data.SQLite;

namespace Topical_Memory_System
{
    public partial class EditCustomVerses : Form
    {
        private List<VersePack> CustomVerses;
        private List<Verse> verses;      //verses for the currently selected custom group in the drop down
        private Verse currentVerse;

        public EditCustomVerses(List<VersePack> IncomingCustomVerses)
        {
            this.CustomVerses = IncomingCustomVerses;
            InitializeComponent();
            UpdateGroupNames(null, null);
        }

        private void UpdateGroupNames(object sender, EventArgs e)
        {
            groupNames.Items.Clear();
			foreach (VersePack vp in CustomVerses)
            {
				groupNames.Items.Add(vp.Name);
            }
			groupNames.SelectedIndex = 0;
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            groupName.Text = groupNames.Text;
            versesListBox.Items.Clear();
			foreach (VersePack vp in CustomVerses)
            {
				if (vp.Name == groupNames.Text)
                {
					verses = vp.Verses;
                    foreach (Verse v in verses)
                    {
                        versesListBox.Items.Add(v.getReference());
                    }
                    versesListBox.SelectedIndex = -1;
                }
            }
            verseNameBox.Text = "";
            verseReferenceBox.Text = "";
            verseDataBox.Text = "";
            SaveGroupNameButton.Enabled = false;
            DeleteVerseButton.Enabled = false;
            UpdateVerseButton.Enabled = false;
        }

        private void VerseSelected(object sender, EventArgs e)
        {
			if (versesListBox.SelectedIndex > -1)
			{
				currentVerse = verses[versesListBox.SelectedIndex];
				verseNameBox.Text = currentVerse.getBook();
				verseReferenceBox.Text = currentVerse.getChapter() + ":" + currentVerse.getVerseNumbers();
				verseDataBox.Text = currentVerse.getVerseData();
				DeleteVerseButton.Enabled = true;
				UpdateVerseButton.Enabled = false;
			}
        }

        private void VerseValueChanged(object sender, EventArgs e)
        {
            UpdateVerseButton.Enabled = true;
        }

        private void GroupNameChanged(object sender, EventArgs e)
        {
            SaveGroupNameButton.Enabled = true;
        }

        private void SaveGroupNameButton_Click(object sender, EventArgs e)
        {
            bool nameAlreadyUsed = false;
            foreach (String obj in groupNames.Items)
            {
                if (groupName.Text.Equals(obj))
                {
                    nameAlreadyUsed = true;
                    break;
                }
            }
            if (nameAlreadyUsed)
            {
                MessageBox.Show("That name is already in use.  Please select another.");
            }
            else if (groupName.Text.Trim().Length == 0)
            {
                MessageBox.Show("The name cannot be left blank.");
            }
            else
            {
                UpdateGroupName(groupNames.Text, groupName.Text.Trim());
            }
        }

        private void DeleteVerseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this verse?", "Delete Verse Confirmation", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                DeleteVerse(currentVerse);
            }
        }

        private void UpdateVerseButton_Click(object sender, EventArgs e)
        {
            if (verseNameBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("The verse book cannot be left blank.");
            }
            else if (verseReferenceBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("The verse reference cannot be left blank.");
            }
            else if (verseDataBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("The verse cannot be left blank.");
            }
            else
            {
                Verse newVerse = new Verse(verseNameBox.Text.Trim(), Convert.ToInt32(verseReferenceBox.Text.Split(':')[0].Trim()),
                    verseReferenceBox.Text.Split(':')[1].Trim(), "", "", "", verseDataBox.Text.Trim().Replace("'", "''"), "", "", "", "", false);
				UpdateVerse(currentVerse, newVerse);
            }
        }

        private void UpdateGroupName(string oldName, string newName)
        {
			SQLiteConnection conn;
			SQLiteCommand cmd;

			//set up connection
			conn = new SQLiteConnection(Constants.DatabaseConnectionString);
			conn.Open();
			cmd = conn.CreateCommand();

			//insert statement
			cmd.CommandText = "UPDATE CustomGroups SET Name = '" + newName.Replace("'", "''") + "' WHERE (CustomGroups.Name = '" + oldName.Replace("'", "''") + "');";
			cmd.ExecuteNonQuery();

			int result = cmd.ExecuteNonQuery();
			conn.Close();

			CustomVerses = MenuExit.LoadCustomVerses();
			UpdateGroupNames(null, null);
			MessageBox.Show("Group name updated!");
        }

		private void UpdateVerse(Verse oldVerse, Verse newVerse)
		{
			SQLiteConnection conn;
			SQLiteCommand cmd;

			//set up connection
			conn = new SQLiteConnection(Constants.DatabaseConnectionString);
			conn.Open();
			cmd = conn.CreateCommand();

			//insert statement
			cmd.CommandText = "UPDATE CustomVerses " +
				"SET Book = '" + newVerse.getBook() + "', Chapter = " + newVerse.getChapter() +
					", VerseNumbers = '" + newVerse.getVerseNumbers() + "', VerseData = '" + newVerse.getVerseData() + "' " +
				"WHERE (CustomVerses.Book = '" + oldVerse.getBook() + "') AND (CustomVerses.Chapter = " + oldVerse.getChapter() + ") AND " +
					"(CustomVerses.VerseNumbers = '" + oldVerse.getVerseNumbers() + "') AND (CustomVerses.VerseData = '" + oldVerse.getVerseData().Replace("'", "''") + "');";
			cmd.ExecuteNonQuery();

			int result = cmd.ExecuteNonQuery();
			conn.Close();

			CustomVerses = MenuExit.LoadCustomVerses();
			UpdateGroupNames(null, null);
			MessageBox.Show("Verse updated!");
		}

		private void DeleteVerse(Verse oldVerse)
		{
			SQLiteConnection conn;
			SQLiteCommand cmd;

			//set up connection
			conn = new SQLiteConnection(Constants.DatabaseConnectionString);
			conn.Open();
			cmd = conn.CreateCommand();

			//insert statement
			cmd.CommandText = "DELETE FROM CustomVerses " + 
				"WHERE (CustomVerses.Book = '" + oldVerse.getBook() + "') AND (CustomVerses.Chapter = " + oldVerse.getChapter() + ") AND " +
					"(CustomVerses.VerseNumbers = '" + oldVerse.getVerseNumbers() + "') AND (CustomVerses.VerseData = '" + oldVerse.getVerseData().Replace("'", "''") + "');";
			cmd.ExecuteNonQuery();

			int result = cmd.ExecuteNonQuery();
			conn.Close();

			CustomVerses = MenuExit.LoadCustomVerses();
			UpdateGroupNames(null, null);
			MessageBox.Show("Verse deleted.");
		}
    }
}
