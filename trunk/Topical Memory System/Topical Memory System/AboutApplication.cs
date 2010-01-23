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
    public partial class AboutApplication : Form
    {
        public AboutApplication()
        {
            InitializeComponent();
			VersionBox.Text = "Version " + Constants.Version;
            richTextBox3.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto: benderrr@uwec.edu");
            }
            catch (Win32Exception exc)
            {
                exc.ToString();
            }
        }

        private void MainUnfocus(object sender, EventArgs e)
        {
            ((RichTextBox)sender).SelectionLength = 0;
           richTextBox3.Focus();
        }

        private void Unfocus(object sender, MouseEventArgs e)
        {
            MainUnfocus(sender, null);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox3.SelectAll();
            Clipboard.SetText(richTextBox3.SelectedText);
        }
    }
}
