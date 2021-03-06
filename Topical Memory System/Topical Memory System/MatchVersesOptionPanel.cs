﻿using System;
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

        private void MatchReferencesToVersesButton_Click(object sender, EventArgs e)
        {
            MenuExit.MatchVersesHandler(this, false);
        }

        private void MatchVersesToReferencesButton_Click(object sender, EventArgs e)
        {
            MenuExit.MatchVersesHandler(this, true);
        }
    }
}
