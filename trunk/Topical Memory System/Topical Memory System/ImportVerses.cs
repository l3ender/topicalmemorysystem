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
		private List<VersePack> VerseGroups;	//indexes relate to custom verse group names indexes
		private List<string> CustomGroupNames;
		private int PreviousSelectedIndex;		//need to store so when group name is changed, we can save the verses in the box

		public ImportVerses(string fileName, List<string> groupNames)
		{
			InitializeComponent();
			List<Verse> Verses = ReadInVerses(fileName);
			foreach (Verse v in Verses)
			{
				VersesBox.Items.Add(v);
			}
			this.CustomGroupNames = groupNames;
			VerseGroups = new List<VersePack>(CustomGroupNames.Count);
			foreach (string s in CustomGroupNames)
			{
				GroupNamesDropDown.Items.Add(s);
				VersePack vp = new VersePack();
				vp.SetName(s);
				VerseGroups.Add(vp);
				GroupStatsBox.Items.Add(s + " - 0 verses placed");
			}
			if (CustomGroupNames.Count > 0)
			{
				GroupNamesDropDown.SelectedIndex = 0;
				PreviousSelectedIndex = 0;
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

		private void GroupNamesDropDown_SelectedIndexChanged(object sender, EventArgs e)
		{
			//save verses in the list, if any
			foreach (object obj in PlacedVersesBox.Items)
			{
				if (!VerseGroups[PreviousSelectedIndex].Verses.Contains((Verse)obj))
				{
					VerseGroups[PreviousSelectedIndex].Verses.Add((Verse)obj);
				}
			}

			PreviousSelectedIndex = GroupNamesDropDown.SelectedIndex;
			PlacedVersesBox.Items.Clear();

			//add verses from index change (ones that are already stored):
			foreach (Verse v in VerseGroups[PreviousSelectedIndex].Verses)
			{
				PlacedVersesBox.Items.Add(v);
			}
			if (PlacedVersesBox.Items.Count > 0)
			{
				RemoveAllButton.Enabled = true;
			}
			else
			{
				RemoveAllButton.Enabled = false;
			}
			if (VersesBox.Items.Count > 0)
			{
				AddAllButton.Enabled = true;
			}
			else
			{
				AddAllButton.Enabled = false;
			}
			RemoveButton.Enabled = false;
		}

		private void VersesBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			AddButton.Enabled = true;
		}

		private void VerseBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			RemoveButton.Enabled = true;
		}

		private void AddVerseButton_Click(object sender, EventArgs e)
		{
			foreach (object obj in VersesBox.SelectedItems)
			{
				PlacedVersesBox.Items.Add((Verse)obj);
			}
			foreach (object obj in PlacedVersesBox.Items)
			{
				if (VersesBox.Items.Contains((Verse)obj))
				{
					VersesBox.Items.Remove((Verse)obj);
				}
				if (!VerseGroups[GroupNamesDropDown.SelectedIndex].Verses.Contains((Verse)obj))
				{
					VerseGroups[GroupNamesDropDown.SelectedIndex].Verses.Add((Verse)obj);
				}
			}
			if (VersesBox.Items.Count < 1)
			{
				AddAllButton.Enabled = false;
				AddButton.Enabled = false;
			}
			RemoveAllButton.Enabled = true;
			//update stats:
			GroupStatsBox.Items[GroupNamesDropDown.SelectedIndex] = GroupNamesDropDown.Text + " - " + PlacedVersesBox.Items.Count.ToString() + " verses placed";
		}

		private void AddAllButton_Click(object sender, EventArgs e)
		{
			foreach (object obj in VersesBox.Items)
			{
				PlacedVersesBox.Items.Add((Verse)obj);
			}
			foreach (object obj in PlacedVersesBox.Items)
			{
				if (VersesBox.Items.Contains((Verse)obj))
				{
					VersesBox.Items.Remove((Verse)obj);
				}
				if (!VerseGroups[GroupNamesDropDown.SelectedIndex].Verses.Contains((Verse)obj))
				{
					VerseGroups[GroupNamesDropDown.SelectedIndex].Verses.Add((Verse)obj);
				}
			}
			AddAllButton.Enabled = false;
			AddButton.Enabled = false;
			RemoveAllButton.Enabled = true;
			//update stats:
			GroupStatsBox.Items[GroupNamesDropDown.SelectedIndex] = GroupNamesDropDown.Text + " - " + PlacedVersesBox.Items.Count.ToString() + " verses placed";
		}

		private void RemoveVerseButton_Click(object sender, EventArgs e)
		{
			foreach (object obj in PlacedVersesBox.SelectedItems)
			{
				VersesBox.Items.Add((Verse)obj);
			}
			foreach (object obj in VersesBox.Items)
			{
				if (PlacedVersesBox.Items.Contains((Verse)obj))
				{
					PlacedVersesBox.Items.Remove((Verse)obj);
				}
				if (VerseGroups[GroupNamesDropDown.SelectedIndex].Verses.Contains((Verse)obj))
				{
					VerseGroups[GroupNamesDropDown.SelectedIndex].Verses.Remove((Verse)obj);
				}
			}
			if (PlacedVersesBox.Items.Count < 1)
			{
				RemoveAllButton.Enabled = false;
				RemoveButton.Enabled = false;
			}
			AddAllButton.Enabled = true;
			//update stats:
			GroupStatsBox.Items[GroupNamesDropDown.SelectedIndex] = GroupNamesDropDown.Text + " - " + PlacedVersesBox.Items.Count.ToString() + " verses placed";
		}

		private void RemoveAllButton_Click(object sender, EventArgs e)
		{
			foreach (object obj in PlacedVersesBox.Items)
			{
				VersesBox.Items.Add((Verse)obj);
			}
			foreach (object obj in VersesBox.Items)
			{
				if (PlacedVersesBox.Items.Contains((Verse)obj))
				{
					PlacedVersesBox.Items.Remove((Verse)obj);
				}
				if (VerseGroups[GroupNamesDropDown.SelectedIndex].Verses.Contains((Verse)obj))
				{
					VerseGroups[GroupNamesDropDown.SelectedIndex].Verses.Remove((Verse)obj);
				}
			}
			RemoveAllButton.Enabled = false;
			RemoveButton.Enabled = false;
			AddAllButton.Enabled = true;
			//update stats:
			GroupStatsBox.Items[GroupNamesDropDown.SelectedIndex] = GroupNamesDropDown.Text + " - " + PlacedVersesBox.Items.Count.ToString() + " verses placed";
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (VersesBox.Items.Count > 0)
			{
				if (MessageBox.Show("You have not placed all the verses.  Would you like to continue without doing so?", "Import Verses Confirmation", MessageBoxButtons.YesNo)
					== DialogResult.Yes)
				{
					foreach (VersePack vp in VerseGroups)
					{
						if (vp.Verses.Count > 0)
						{
							AddVersesToDatabase(vp.Verses, vp.Name);
						}
					}
					MessageBox.Show("Verses successfully imported!");
					this.Close();
				}
			}
			else
			{
				foreach (VersePack vp in VerseGroups)
				{
					if (vp.Verses.Count > 0)
					{
						AddVersesToDatabase(vp.Verses, vp.Name);
					}
				}
				MessageBox.Show("Verses successfully imported!");
				this.Close();
			}
		}

		private static void AddVersesToDatabase(List<Verse> verses, string groupName)
		{
			try
			{
				MenuExit.SaveMultipleVersesToDatabase(verses, groupName);
			}
			catch (Exception)
			{
				MessageBox.Show("An error occurred while importing the verses.  Please contact the project's administrator.");
			}
		}

		private void ShowHelpButton_Click(object sender, EventArgs e)
		{
			ImportVersesHelp ivh = new ImportVersesHelp();
			ivh.ShowDialog();
		}

	}
}
