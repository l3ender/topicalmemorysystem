using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Topical_Memory_System
{
	public partial class reviewVersesOptionsPanel : UserControl
	{
		public reviewVersesOptionsPanel()
		{
			InitializeComponent();
		}

		private void PaintMethod(object sender, PaintEventArgs e)
		{
			Pen myPen;
			myPen = new Pen(Color.Black, 1);
			Graphics formGraphics = this.CreateGraphics();
			formGraphics.DrawRectangle(myPen, 185, 25, 250, 300);
			myPen.Dispose();
			formGraphics.Dispose();
		}

		private void CheckBoxClicked(object sender, EventArgs e)
		{
			if (((CheckBox)sender).Name.ToString().Equals("allPacksCheck"))
			{
				if (((CheckBox)sender).Checked)
				{
					//disable all the others
					aPackCheck.Checked = false;
					bPackCheck.Checked = false;
					cPackCheck.Checked = false;
					dPackCheck.Checked = false;
					ePackCheck.Checked = false;
				}
			}
			else
			{
				if (((CheckBox)sender).Checked)
				{
					allPacksCheck.Checked = false;
				}
			}
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			List<string> packs = new List<string>();
			if (allPacksCheck.Checked)
			{
				packs.Add("all");
			}
			else
			{
				if (aPackCheck.Checked)
				{
					packs.Add("A");
				}
				if (bPackCheck.Checked)
				{
					packs.Add("B");
				}
				if (cPackCheck.Checked)
				{
					packs.Add("C");
				}
				if (dPackCheck.Checked)
				{
					packs.Add("D");
				}
				if (ePackCheck.Checked)
				{
					packs.Add("E");
				}
			}
			//defaults to all
			if (packs.Count() == 0)
			{
				packs.Add("all");
			}
			MenuExit.reviewVerses(packs, this);
		}
	}
}
