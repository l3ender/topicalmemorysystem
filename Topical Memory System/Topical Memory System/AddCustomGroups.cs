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
	public partial class AddCustomGroups : Form
	{
		private List<VersePack> CustomVerses;

		public AddCustomGroups(List<VersePack> IncomingCustomVerses)
		{
			InitializeComponent();
			this.CustomVerses = IncomingCustomVerses;
			NewGroupName.Focus();
		}

		private void CreateGroupButton_Click(object sender, EventArgs e)
		{
			bool nameAlreadyUsed = false;
			foreach (VersePack vp in CustomVerses)
			{
				if (NewGroupName.Text.Equals(vp.ToString()))
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
				MenuExit.CreateGroup(NewGroupName.Text);
				CreateGroupButton.Enabled = false;
				NewGroupName.Text = "";
				NewGroupName.Focus();
				CustomVerses = MenuExit.LoadCustomVerses();
				MessageBox.Show("Group successfully created!");
			}
		}

		private void NewGroupName_TextChanged(object sender, EventArgs e)
		{
			CreateGroupButton.Enabled = true;
		}

		private void NewGroupName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				CreateGroupButton_Click(null, null);
			}
		}
	}
}
