using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Topical_Memory_System
{
	public partial class MainMenuPanel : UserControl
	{

        public MainMenuPanel()
		{
			InitializeComponent();
		}

		private void ReviewVersesButton_Click(object sender, EventArgs e)
		{
			MenuExit.ReviewVersesHandler(this);
		}

        private void MatchVersesButton_Click(object sender, EventArgs e)
        {
            MenuExit.MatchVersesHandler(this);
        }

		private void LearnVersesButton_Click(object sender, EventArgs e)
		{
			MenuExit.LearnVersesHandler(this);
		}
	}
}
