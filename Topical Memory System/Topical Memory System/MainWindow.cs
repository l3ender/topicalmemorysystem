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
using System.Collections;

namespace Topical_Memory_System
{
	public partial class MenuExit : Form
	{
		public MenuExit()
		{
			InitializeComponent();
			LoadConfigFile();
			mainPanel.Controls.Add(new MainMenuPanel());
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
			if (mainPanel.Controls[0] is ReviewVerses)
			{
				int translation = 0;
				if (esvStripMenuItem.Checked)
				{
					translation = 1;
				}
				ReviewVerses.ChangeTranslation(translation);
			}
		}

		public static void reviewVerses(object sender, EventArgs e)
		{
			mainPanel.Controls.Remove((Control)sender);
			mainPanel.Controls.Add(new reviewVersesOptionsPanel());
		}

		public static void reviewVerses(List<string> packs, object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
			List<Verse> allVerses = ReadInVerses();
			List<Verse> versesToReview = new List<Verse>();
			if (packs.Contains("all"))
			{
				versesToReview = allVerses;
			}
			else
			{
				foreach (Verse v in allVerses)
				{
					if (packs.Contains(v.getPackLetter()))
					{
						versesToReview.Add(v);
					}
				}
			}
			string translation = "NIV";
			if (esvStripMenuItem.Checked)
			{
				translation = "ESV";
			}
			Hashtable topics = ReadInTopics();
			mainPanel.Controls.Add(new ReviewVerses(versesToReview, translation, topics));
		}

		private static List<Verse> ReadInVerses()
		{
			List<Verse> allVerses = new List<Verse>();
			StreamReader SR;
			string S;
			SR = File.OpenText(Constants.NivFileLocation);
			S = SR.ReadLine();
			while (S != null)
			{
				if (S.Trim().Length > 0)
				{
					string[] info = S.Split('/');
					Verse v = new Verse(info[0], Convert.ToInt32(info[1].Split(':')[0]), info[1].Split(':')[1],
						info[2].Split(' ')[0], Convert.ToInt32(info[2].Split(' ')[1]), info[3]);
					allVerses.Add(v);
				}
				S = SR.ReadLine();
			}
			SR.Close();

			SR = File.OpenText(Constants.EsvFileLocation);
			S = SR.ReadLine();
			int i = 0;
			while (S != null)
			{
				if (S.Trim().Length > 0)
				{
					string[] info = S.Split('/');
					allVerses[i].setEsvVerseData(info[3]);
					i++;
				}
				S = SR.ReadLine();
			}
			SR.Close();
			return allVerses;
		}

		private static Hashtable ReadInTopics()
		{
			Hashtable topics = new Hashtable();		//stored as <pack#, hashtable<pack#, topics>>
			string fileLocation = Constants.TmsTopicsFileLocation;
			StreamReader SR;
			string S;
			SR = File.OpenText(fileLocation);
			S = SR.ReadLine();
			for (int i = 0; i < 5; i++)
			{
				Hashtable inner = new Hashtable();
				for (int j = 0; j < 7; j++)
				{
					if (S != null && S.Trim().Length > 0)
					{
						inner.Add(j, S.Trim());
					}
					S = SR.ReadLine();
				}
				topics.Add((i + 1), inner);
			}
			SR.Close();
			return topics;
		}

		private void MainMenuStripClick(object sender, EventArgs e)
		{
			while (mainPanel.Controls.Count > 0)
			{
				mainPanel.Controls.RemoveAt(0);
			}
			mainPanel.Controls.Add(new MainMenuPanel());
		}
	}
}
