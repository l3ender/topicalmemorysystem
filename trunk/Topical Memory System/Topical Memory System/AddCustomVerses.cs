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

        private Hashtable CustomVerses;

        public AddCustomVerses(Hashtable IncomingCustomVerses)
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (DictionaryEntry obj in CustomVerses)
            {
                if (groupNames.Text.Equals(((string)obj.Key).Split('~')[1]))
                {
                    //2 Corinthians/5:17/Therefore, if anyone is in Christ, he is a new creation.
                    File.AppendAllText(((string)obj.Key).Split('~')[0] + ".txt", "\r\n" + bookBox.Text +
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
