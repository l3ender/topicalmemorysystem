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
	public partial class LearnVersesOptionPanel : UserControl
	{
		public LearnVersesOptionPanel()
		{
			InitializeComponent();
		}

		private void LearnReferencesButton_Click(object sender, EventArgs e)
		{
			MenuExit.LearnVersesHandler(this, true);
		}

		private void ReciteVersesButton_Click(object sender, EventArgs e)
		{
			MenuExit.LearnVersesHandler(this, false);
		}
	}
}
