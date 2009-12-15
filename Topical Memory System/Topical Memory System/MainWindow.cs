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
using System.Speech.Synthesis;
using System.Globalization;

namespace Topical_Memory_System
{
	public partial class MenuExit : Form
	{
		public MenuExit()
		{
			InitializeComponent();
			LoadConfigFile();
			mainPanel.Controls.Add(new ReviewVersesPanel());
		}

		private void LoadConfigFile()
		{
			StreamReader SR = null;
			string S;
			bool good = true;
			try
			{
				SR = File.OpenText(Constants.ConfigFileLocation);
			}
			catch (System.IO.FileNotFoundException)
			{
				good = false;
				//create the file
				WriteToConfig("primarytranslation=niv");
			}
			if (good)
			{
				S = SR.ReadLine();
				while (S != null)
				{
					if (S.Trim().Length > 0)
					{
						string[] info = S.Split('=');
						if (info[0].Equals("primarytranslation"))
						{
							if (info[1].Equals("esv"))
							{
								esvStripMenuItem.Checked = true;
								nivStripMenuItem.Checked = false;
								nivStripMenuItem.CheckState = CheckState.Unchecked;
							}
							else if (info[1].Equals("niv"))
							{
								nivStripMenuItem.Checked = true;
								esvStripMenuItem.Checked = false;
								esvStripMenuItem.CheckState = CheckState.Unchecked;
							}
						}
					}
					S = SR.ReadLine();
				}
				SR.Close();
			}
		}

		private void WriteToConfig(string s)
		{
			File.AppendAllText(Constants.ConfigFileLocation, s);
		}

		private void MenuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ReadFromFile()
		{
			StreamReader SR;
			string S;
			SR = File.OpenText("../../tmsResources/tmsVerses-NIV.txt");
			S = SR.ReadLine();
			while (S != null)
			{
				if (S.Trim().Length > 0)
				{
					string[] info = S.Split('/');
					Verse v = new Verse(info[0], Convert.ToInt32(info[1].Split(':')[0]), info[1].Split(':')[1],
						info[2].Split(' ')[0], Convert.ToInt32(info[2].Split(' ')[1]), info[3]);
					SpeechSynthesizer speaker = new SpeechSynthesizer();
					speaker.Rate = -2;
					speaker.Volume = 100;
					speaker.Speak(v.getReference());
					speaker.Speak(v.getVerseData());
					Debug.WriteLine(v.getReference());
					Debug.WriteLine(v.getVerseData());
				}
				S = SR.ReadLine();
			}
			SR.Close();
		}

		private void TranslationChanged(object sender, EventArgs e)
		{
			if (sender is ToolStripMenuItem)
			{
				foreach (ToolStripMenuItem item in (((ToolStripMenuItem)sender).GetCurrentParent().Items))
				{
					if (item == sender)
					{
						item.Checked = true;
					}
					if ((item != null) && (item != sender))
					{
						item.Checked = false;
					}
				}
			}
		}

		public static void reviewVerses(object sender, EventArgs e)
		{
			foreach (Control c in mainPanel.Controls)
			{
				c.Enabled = false;
				c.Visible = false;
			}
			mainPanel.Controls.Add(new MatchingVersesPanel());
		}
	}
}
