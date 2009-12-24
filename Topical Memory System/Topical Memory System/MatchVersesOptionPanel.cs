using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Topical_Memory_System
{
    public partial class MatchVersesOptionPanel : UserControl
    {
        public MatchVersesOptionPanel()
        {
            InitializeComponent();
        }

        private void matchReferencesToVersesButton_Click(object sender, EventArgs e)
        {
            MenuExit.matchVerses(this, false);
        }

        private void matchVersesToReferencesButton_Click(object sender, EventArgs e)
        {
            MenuExit.matchVerses(this, true);
        }
    }
}
