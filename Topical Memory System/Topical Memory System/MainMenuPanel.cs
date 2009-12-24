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
	public partial class MainMenuPanel : UserControl
	{
		public MainMenuPanel()
		{
			InitializeComponent();
		}

		private void reviewVersesButton_Click(object sender, EventArgs e)
		{
			MenuExit.reviewVerses(this);
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
