using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Topical_Memory_System
{
	public partial class MenuExit : Form
	{
		public MenuExit()
		{
			InitializeComponent();
		}

		private void MenuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ReadFromFile(object sender, EventArgs e)
		{
			StreamReader SR;
			string S;
			SR = File.OpenText("../../../tmsVerses-ESV.txt");
			S = SR.ReadLine();
			while (S != null)
			{
				if (S.Trim().Length > 0)
				{
					string[] info = S.Split('/');
					Verse v = new Verse(info[0], Convert.ToInt32(info[1].Split(':')[0]), info[1].Split(':')[1],
						info[2].Split(' ')[0], Convert.ToInt32(info[2].Split(' ')[1]), info[3]);
					Debug.WriteLine(v.getReference());
					Debug.WriteLine(v.getVerseData());
					S = SR.ReadLine();
				}
				else
				{
					S = SR.ReadLine();
				}
			}
			SR.Close();
		}
	}
}
