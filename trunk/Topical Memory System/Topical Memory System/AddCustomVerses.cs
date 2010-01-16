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

namespace Topical_Memory_System
{
    public partial class AddCustomVerses : Form
    {

        private List<VersePack> CustomVerses;

        public AddCustomVerses(List<VersePack> IncomingCustomVerses)
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

        private void saveButton_Click(object sender, EventArgs e)
        {
			bool okay = true;
			if (bookBox.Text.Trim() == "" || referenceBox.Text.Trim() == "" || verseDataBox.Text.Trim() == "")
			{
				MessageBox.Show("You must enter the book, reference, and verse!");
				okay = false;
			}
			if (okay)
			{
				foreach (VersePack vp in CustomVerses)
				{
					if (groupNames.Text == vp.Name)
					{
						//2 Corinthians/5:17/Therefore, if anyone is in Christ, he is a new creation.
						File.AppendAllText(vp.FileLocation, "\r\n" + bookBox.Text +
							Constants.FileDelimiter + referenceBox.Text + Constants.FileDelimiter + verseDataBox.Text);
						break;
					}
				}
				MessageBox.Show("Verse saved!");
				groupNames.SelectedIndex = 0;
				bookBox.Text = "";
				referenceBox.Text = "";
				verseDataBox.Text = "";
			}
        }
    }
}
