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
			MenuExit.reviewVerses(this, e);
		}
	}
}
