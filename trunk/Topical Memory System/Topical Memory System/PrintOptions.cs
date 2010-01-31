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
	public partial class PrintOptions : Form
	{
		public PrintOptions()
		{
			InitializeComponent();
		}

		private void PrintButton_Click(object sender, EventArgs e)
		{
			if (ReferenceRadio.Checked)
			{
				this.DialogResult = DialogResult.No;		//just references
			}
			else if (VerseRadio.Checked)
			{
				this.DialogResult = DialogResult.Ignore;	//just verses
			}
			else
			{
				this.DialogResult = DialogResult.Yes;		//both
			}
			this.Close();
		}
	}
}
