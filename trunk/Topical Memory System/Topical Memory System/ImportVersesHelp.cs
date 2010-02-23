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
	public partial class ImportVersesHelp : Form
	{
		public ImportVersesHelp()
		{
			InitializeComponent();
			this.TextBox.Text = Constants.Tab + "To import verses, start by selecting the verses on the left.  You can then place those verses by clicking the \"Add Verses\" button.  The verses you selected are added to the custom group on the right.  You can easily add all the verses that are being imported at one time by clicking the \"Add All\" button." + Constants.NewLine + Constants.NewLine + Constants.Tab + "Verses that are being imported can also be added to multiple groups.  For example, if some of the verses related to the theme of one custom group and some to another group, you can divide the verses into the seperate groups.  Simply add the verses to the first group, change the group with the dropdown menu on the right, and add the other verses to that group.  The number of verses that are placed in each group is displayed in the lower right-hand corner." + Constants.NewLine + Constants.NewLine + Constants.Tab + "You are able to undo placement into a group by selecting the verses in that group and clicking the \"Remove Verses\" button.  You can undo all the verses in a particular group by selecting the \"Remove All\" button." + Constants.NewLine + Constants.NewLine + Constants.Tab + "When you have placed the verses that you wish, select the \"Finalize Import\" button.  The verses will not be saved to your program until you complete the import by doing this.";
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
