using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Topical_Memory_System
{
    public partial class EditCustomVerses : Form
    {

        private Hashtable CustomVerses;

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
                    List<Verse> verses = ((List<Verse>)obj.Value);
                    foreach (Verse v in verses)
                    {
                        versesListBox.Items.Add(v.getReference());
                    }
                    versesListBox.SelectedIndex = -1;
                }
            }
        }
    }
}
