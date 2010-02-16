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
        private static List<VersePack> CustomVerses;
        private List<Verse> verses;      //verses for the currently selected custom group in the drop down
        private Verse currentVerse;

        public EditCustomVerses(List<VersePack> IncomingCustomVerses)
        {
            CustomVerses = IncomingCustomVerses;
            InitializeComponent();
            UpdateGroupNames(null, null);
        }

        private static void UpdateGroupNames(object sender, EventArgs e)
        {
            groupNames.Items.Clear();
			foreach (VersePack vp in CustomVerses)
            {
				if (vp.Verses.Count > 0)
				{
					groupNames.Items.Add(vp.Name);
				}
            }
			if (groupNames.Items.Count > 0)
			{
				groupNames.SelectedIndex = 0;
			}
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    verseReferenceBox.Text.Split(':')[1].Trim(), "", "", "", verseDataBox.Text.Trim(), "", "", "", "", false);
				UpdateVerse(currentVerse, newVerse);
            }
        }

		private static void UpdateVerse(Verse oldVerse, Verse newVerse)
		{
			try
			{
				MenuExit.UpdateVerse(oldVerse, newVerse);
				CustomVerses = MenuExit.LoadCustomVerses();

				//save state so that we remain on the same selected group
				object obj = groupNames.SelectedItem;
				UpdateGroupNames(null, null);
				groupNames.SelectedItem = obj;
				MessageBox.Show("Verse updated!");
			}
			catch (Exception)
			{
				MessageBox.Show("A problem occurred while updating the verse.");
			}
		}

		private static void DeleteVerse(Verse oldVerse)
		{
			try
			{
				MenuExit.DeleteVerse(oldVerse);
				CustomVerses = MenuExit.LoadCustomVerses();

				//save state so that we remain on the same selected group
				object obj = groupNames.SelectedItem;
				UpdateGroupNames(null, null);
				groupNames.SelectedItem = obj;
				MessageBox.Show("Verse deleted.");
			}
			catch (Exception)
			{
				MessageBox.Show("A problem occurred while deleting the verse.");
			}
		}
    }
}
