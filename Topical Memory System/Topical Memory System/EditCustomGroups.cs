using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Topical_Memory_System
{
	public partial class EditCustomGroups : Form
	{
		private List<VersePack> CustomVerses;

		public EditCustomGroups(List<VersePack> IncomingCustomVerses)
		{
			InitializeComponent();
			this.CustomVerses = IncomingCustomVerses;
			LoadGroupNames();
		}

		private void LoadGroupNames()
		{
			GroupNames.Items.Clear();
			foreach (VersePack vp in CustomVerses)
			{
				GroupNames.Items.Add(vp);
			}
		}

		private void SaveGroupName_Click(object sender, EventArgs e)
		{
			bool nameAlreadyUsed = false;
			foreach (VersePack obj in GroupNames.Items)
			{
				if (NewGroupName.Text.Equals(obj.ToString()))
				{
					nameAlreadyUsed = true;
					break;
				}
			}
			if (nameAlreadyUsed)
			{
				MessageBox.Show("That name is already in use.  Please select another.");
			}
			else if (NewGroupName.Text.Trim().Length == 0)
			{
				MessageBox.Show("The name cannot be left blank.");
			}
			else if (NewGroupName.Text.Trim().Length > Constants.MaximumCharactersForCustomGroupName)
			{
				MessageBox.Show("The name you entered is too long.  Please enter a name under 20 characters long.");
			}
			else
			{
				MenuExit.UpdateGroupName(GroupNames.Text, NewGroupName.Text.Trim());
				CustomVerses = MenuExit.LoadCustomVerses();
				LoadGroupNames();
				MessageBox.Show("Group name updated!");
			}
		}

		private void DeleteGroup_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete this group?  Deleting the group will also delete all the verses in the group (" + ((VersePack)(GroupNames.SelectedItem)).Verses.Count.ToString() + " verses).", 
								"Delete Group Confirmation", MessageBoxButtons.YesNo)
				== DialogResult.Yes)
			{
				NewGroupName.Text = "";
				MenuExit.DeleteGroupName(GroupNames.Text);
				CustomVerses = MenuExit.LoadCustomVerses();
				LoadGroupNames();
				MessageBox.Show("Group deleted.");
			}
		}

		private void GroupNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			NewGroupName.Text = GroupNames.Text;
			SaveGroupName.Enabled = false;
			DeleteGroup.Enabled = true;
		}

		private void NewGroupName_TextChanged(object sender, EventArgs e)
		{
			SaveGroupName.Enabled = true;
		}
	}
}
