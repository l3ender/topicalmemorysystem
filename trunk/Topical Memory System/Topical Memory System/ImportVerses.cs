using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Topical_Memory_System
{
	public partial class ImportVerses : Form
	{
		private static List<Verse> Verses;

		public ImportVerses(string fileName)
		{
			InitializeComponent();
			FillCustomGroupNames();
			Verses = ReadInVerses(fileName);
			foreach (Verse v in Verses)
			{
				VersesBox.Items.Add(v.getReference());
			}
		}

		private static void FillCustomGroupNames()
		{
			List<string> names = MenuExit.LoadCustomGroupNames();
			if (names.Count == 5)
			{
				CustomGroupLabel1.Text = names[0];
				CustomGroupLabel2.Text = names[1];
				CustomGroupLabel3.Text = names[2];
				CustomGroupLabel4.Text = names[3];
				CustomGroupLabel5.Text = names[4];
			}
		}

		private List<Verse> ReadInVerses(string fileName)
		{
			List<Verse> verses = new List<Verse>();
			string[] lines = File.ReadAllLines(fileName);
			foreach (string s in lines)
			{
				if (s != null && s.Trim().Length > 0)
				{
					string[] parts = s.Split(Convert.ToChar(Constants.FileDelimiter));
					//format: book/chapter/numbers/data
					Verse v = new Verse(parts[0], Convert.ToInt32(parts[1]), parts[2], "", "", "", parts[3], "", "", "", "", false);
					verses.Add(v);
				}
			}
			return verses;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			bool shouldContinue = false;
			if (VersesBox.Items.Count > 0)
			{
				if (MessageBox.Show("You have not placed all the verses.  Do you want to continue?", "Verse Import", MessageBoxButtons.YesNo)
					== DialogResult.Yes)
				{
					shouldContinue = true;
				}
			}
			else
			{
				shouldContinue = true;
			}
			if (shouldContinue)
			{
				try
				{
					AddVersesToDatabase(LoadVersesFromListBox(CustomGroupBox1), CustomGroupLabel1.Text);
					AddVersesToDatabase(LoadVersesFromListBox(CustomGroupBox2), CustomGroupLabel2.Text);
					AddVersesToDatabase(LoadVersesFromListBox(CustomGroupBox3), CustomGroupLabel3.Text);
					AddVersesToDatabase(LoadVersesFromListBox(CustomGroupBox4), CustomGroupLabel4.Text);
					AddVersesToDatabase(LoadVersesFromListBox(CustomGroupBox5), CustomGroupLabel5.Text);
					MessageBox.Show("Import successful!");
				}
				catch (Exception)
				{
					MessageBox.Show("A problem occurred while importing the verses.");
				}
				this.Close();
			}
		}

		private List<Verse> LoadVersesFromListBox(DragDropListBox box)
		{
			List<Verse> verses = new List<Verse>();
			foreach (Verse v in Verses)
			{
				if (box.Items.Contains(v.getReference()))
				{
					verses.Add(v);
				}
			}
			return verses;
		}

		private static void AddVersesToDatabase(List<Verse> verses, string groupName)
		{
			MenuExit.SaveMultipleVersesToDatabase(verses, groupName);
		}

	}
}
