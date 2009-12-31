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

namespace Topical_Memory_System
{
    public partial class EditCustomVerses : Form
    {

        private Hashtable CustomVerses;
        private List<Verse> verses;      //verses for the currently selected custom group in the drop down
        private Verse currentVerse;

        public EditCustomVerses(Hashtable IncomingCustomVerses)
        {
            this.CustomVerses = IncomingCustomVerses;
            InitializeComponent();
            UpdateGroupNames(null, null);
        }

        private void UpdateGroupNames(object sender, EventArgs e)
        {
            groupNames.Items.Clear();
            foreach (DictionaryEntry obj in CustomVerses)
            {
                groupNames.Items.Add(((string)obj.Key).Split('~')[1]);
            }
            groupNames.SelectedIndex = 0;
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            groupName.Text = groupNames.Text;
            versesListBox.Items.Clear();
            foreach (DictionaryEntry obj in CustomVerses)
            {
                if (((string)obj.Key).Split('~')[1].Equals(groupNames.Text))
                {
                    verses = ((List<Verse>)obj.Value);
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
            currentVerse = verses[versesListBox.SelectedIndex];
            verseNameBox.Text = currentVerse.getBook();
            verseReferenceBox.Text = currentVerse.getChapter() + ":" + currentVerse.getVerseNumbers();
            verseDataBox.Text = currentVerse.getVerseData();
            DeleteVerseButton.Enabled = true;
            UpdateVerseButton.Enabled = false;
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
                UpdateGroupName(groupNames.Text, groupName.Text);
            }
        }

        private void DeleteVerseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this verse?", "Delete Verse Confirmation", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                DeleteVerse(currentVerse, groupNames.Text);
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
                Verse newVerse = new Verse(verseNameBox.Text, Convert.ToInt32(verseReferenceBox.Text.Split(':')[0]),
                    verseReferenceBox.Text.Split(':')[1], "", verseDataBox.Text, false);
                UpdateVerse(currentVerse, newVerse, groupNames.Text);
            }
        }

        private void UpdateGroupName(string oldName, string newName)
        {
            string fileName = "";
            foreach (DictionaryEntry obj in CustomVerses)
            {
                if (((string)obj.Key).Split('~')[1].Equals(oldName))
                {
                    fileName = ((string)obj.Key).Split('~')[0];
                    break;
                }
            }
            StreamReader SR;
            string S;
            SR = File.OpenText(fileName + ".txt");
            S = SR.ReadLine();
            string outString = "";
            int index = 0;
            while (S != null)
            {
                if (index == 0)
                {   //title line
                    outString += newName;
                }
                else
                {
                    outString += S;
                }
                outString += "\r\n";
                S = SR.ReadLine();
                index++;
            }
            SR.Close();
            File.WriteAllText(fileName + ".txt", outString);
            CustomVerses = MenuExit.LoadCustomVerses();
            UpdateGroupNames(null, null);
            MessageBox.Show("Name updated!");
        }

        private void UpdateVerse(Verse oldVerse, Verse newVerse, string packName)
        {
            string fileName = "";
            foreach (DictionaryEntry obj in CustomVerses)
            {
                if (((string)obj.Key).Split('~')[1].Equals(packName))
                {
                    fileName = ((string)obj.Key).Split('~')[0];
                    break;
                }
            }
            StreamReader SR;
            string S;
            SR = File.OpenText(fileName + ".txt");
            S = SR.ReadLine();
            string outString = "";
            while (S != null)
            {
                if ((oldVerse.getBook() + Constants.FileDelimiter + oldVerse.getChapter().ToString() +
                    ":" + oldVerse.getVerseNumbers() + Constants.FileDelimiter + 
                    oldVerse.getVerseData()).Equals(S))
                {
                    outString += newVerse.getBook() + Constants.FileDelimiter + newVerse.getChapter().ToString() +
                        ":" + newVerse.getVerseNumbers() + Constants.FileDelimiter +
                        newVerse.getVerseData();
                }
                else
                {
                    outString += S;
                }
                outString += "\r\n";
                S = SR.ReadLine();
            }
            SR.Close();
            File.WriteAllText(fileName + ".txt", outString);
            CustomVerses = MenuExit.LoadCustomVerses();
            UpdateGroupNames(null, null);
            MessageBox.Show("Verse updated!");
        }

        private void DeleteVerse(Verse oldVerse, string packName)
        {
            string fileName = "";
            foreach (DictionaryEntry obj in CustomVerses)
            {
                if (((string)obj.Key).Split('~')[1].Equals(packName))
                {
                    fileName = ((string)obj.Key).Split('~')[0];
                    break;
                }
            }
            StreamReader SR;
            string S;
            SR = File.OpenText(fileName + ".txt");
            S = SR.ReadLine();
            string outString = "";
            while (S != null)
            {
                if ((oldVerse.getBook() + Constants.FileDelimiter + oldVerse.getChapter().ToString() +
                    ":" + oldVerse.getVerseNumbers() + Constants.FileDelimiter +
                    oldVerse.getVerseData()).Equals(S))
                {
                    //do nothing
                }
                else
                {
                    outString += S;
                }
                outString += "\r\n";
                S = SR.ReadLine();
            }
            SR.Close();
            File.WriteAllText(fileName + ".txt", outString);
            CustomVerses = MenuExit.LoadCustomVerses();
            UpdateGroupNames(null, null);
            MessageBox.Show("Verse deleted!");
        }
    }
}
