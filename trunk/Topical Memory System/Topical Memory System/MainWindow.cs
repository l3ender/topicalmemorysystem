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

		private static List<VersePack> AllVerses;

		public MenuExit()
		{
			InitializeComponent();
			AllVerses = ReadInVerses();
            FindInstalledVoices();
            AddAboutStrip();    //add this last manually so it is the right-most strip
			mainPanel.Controls.Add(new MainMenuPanel());
		}

        private void FindInstalledVoices()
        {
            //get the installed voices on the system
            SpeechSynthesizer speechSynth = new SpeechSynthesizer();
            var listOfVoiceInfo = from voice
                                      in speechSynth.GetInstalledVoices(CultureInfo.CurrentCulture)
                                  select voice.VoiceInfo;
            List<VoiceInfo> availableVoices = listOfVoiceInfo.ToList<VoiceInfo>();
            if (availableVoices.Count > 0)
            {
                voiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.menuStrip1.Items.Add(voiceToolStripMenuItem);

                List<ToolStripMenuItem> stripItems = new List<ToolStripMenuItem>(availableVoices.Count);
                for (int i = 0; i < availableVoices.Count; i++)
                {
                    ToolStripMenuItem stripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                    stripMenuItem.Name = availableVoices[i].Name;
                    stripMenuItem.Size = new System.Drawing.Size(240, 22);
                    stripMenuItem.Text = availableVoices[i].Name;
                    stripMenuItem.Click += new System.EventHandler(this.VoiceChanged);
                    if (i == 0)
                    {
                        stripMenuItem.Checked = true;
                    }

                    stripItems.Add(stripMenuItem);
                }

                foreach (ToolStripMenuItem tsmi in stripItems)
                {
                    voiceToolStripMenuItem.DropDownItems.Add(tsmi);
                }

                voiceToolStripMenuItem.Name = "voiceToolStripMenuItem";
                voiceToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
                voiceToolStripMenuItem.Text = "Voice";
            }
        }

        private void AddAboutStrip()
        {	//done so that it is on the furthest right of the strip
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.Items.Add(aboutToolStripMenuItem);

            ToolStripMenuItem infoStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            infoStripMenuItem.Name = "infoStripMenuItem";
            infoStripMenuItem.Size = new System.Drawing.Size(237, 22);
            infoStripMenuItem.Text = "Project Homepage";
            infoStripMenuItem.Click += new System.EventHandler(this.AboutInfo);
            aboutToolStripMenuItem.DropDownItems.Add(infoStripMenuItem);

            ToolStripMenuItem contactStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contactStripMenuItem.Name = "contactStripMenuItem";
            contactStripMenuItem.Size = new System.Drawing.Size(237, 22);
            contactStripMenuItem.Text = "About TMS Assistant";
            contactStripMenuItem.Click += new System.EventHandler(this.ContactInfo);
            aboutToolStripMenuItem.DropDownItems.Add(contactStripMenuItem);

            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            aboutToolStripMenuItem.Text = "Help";
        }

        public static List<VersePack> LoadCustomVerses()
        {
			List<VersePack> versePacks = new List<VersePack>();
            for (int i = 0; i < Constants.CustomVerseLocations.Length; i++)
            {
                StreamReader SR;
                string S;
                SR = File.OpenText(Constants.CustomVerseLocations[i]);
                S = SR.ReadLine();
                int index = 0;
				VersePack vp = new VersePack(Constants.CustomVerseLocations[i]);
                while (S != null)
                {
                    if (S.Trim().Length > 0)
                    {
                        if (index == 0)
                        {   //title line
                            vp.Name = S;
                        }
                        else
                        {
                            string[] info = S.Split('/');
                            //2 Corinthians/5:17/Therefore, if anyone is in Christ, he is a new creation
                            Verse v = new Verse(info[0], Convert.ToInt32(info[1].Split(':')[0]), info[1].Split(':')[1],
                                vp.Name, "", "", info[2], "", "", "", false);
							vp.AddVerse(v);
                        }
                    }
                    S = SR.ReadLine();
                    index++;
                }
                SR.Close();
				versePacks.Add(vp);
            }
			return versePacks;
        }

		private void MenuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void TranslationChanged(object sender, EventArgs e)
		{
			if (sender is ToolStripMenuItem)
			{
				foreach (ToolStripMenuItem item in translationToolStripMenuItem.DropDownItems)
				{
					if (item == sender)
					{
						item.Checked = true;
						if (item.Tag.Equals("NBV"))
						{	//also automatically switch browser viewing, too
							BibleSelected(biblijaToolStripMenuItem, null);
						}
						else
						{
							BibleSelected(blueLetterBibleToolStripMenuItem, null);
						}
					}
					if ((item != null) && (item != sender))
					{
						item.Checked = false;
					}
				}
			}
            if (mainPanel.Controls.Count > 0)
            {
                if (mainPanel.Controls[0] is ReviewVerses)
                {
                    ReviewVerses.ChangeTranslation(SelectedTranslationName());
                }
                else if (mainPanel.Controls[0] is MatchVerses)
                {
                    MatchVerses.ChangeTranslation(SelectedTranslationName());
				}
				else if (mainPanel.Controls[0] is LearnVerses)
				{
					LearnVerses.ChangeTranslation(SelectedTranslationName());
				}
				else if (mainPanel.Controls[0] is ViewVerses)
				{
					ViewVerses.ChangeTranslation(SelectedTranslationName());
				}
            }
		}

        private void VoiceChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                foreach (ToolStripMenuItem item in voiceToolStripMenuItem.DropDownItems)
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

        private void AboutInfo(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://code.google.com/p/topicalmemorysystem/");
        }

        private void ContactInfo(object sender, EventArgs e)
        {
            AboutApplication ab = new AboutApplication();
            ab.Show();
        }

		public static void ViewVersesHandler(object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
			List<VersePack> verses = AllVerses;
			List<VersePack> customVerses = LoadCustomVerses();
			foreach (VersePack vp in customVerses)
			{
				if (vp.Verses.Count > 0)
				{
					verses.Add(vp);
				}
			}
			mainPanel.Controls.Add(new ViewVerses(verses));
		}

		public static void ReviewVersesHandler(object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
			mainPanel.Controls.Add(new ReviewVersesOptionsPanel("review", LoadCustomVerses()));
		}

        public static void MatchVersesHandler(object sender)
        {
            mainPanel.Controls.Remove((Control)sender);
            mainPanel.Controls.Add(new MatchVersesOptionPanel());
        }

		public static void LearnVersesHandler(object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
			mainPanel.Controls.Add(new ReviewVersesOptionsPanel("learn", LoadCustomVerses()));
		}

        public static void MatchVersesHandler(object sender, bool verseToReference)
        {
            mainPanel.Controls.Remove((Control)sender);
            if (verseToReference)
            {
				mainPanel.Controls.Add(new ReviewVersesOptionsPanel("vr", LoadCustomVerses()));
            }
            else
            {
				mainPanel.Controls.Add(new ReviewVersesOptionsPanel("rv", LoadCustomVerses()));
            }
        }

		public static void ReviewVersesHandler(List<VersePack> CustomVerses, List<string> packs, object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
			List<Verse> versesToReview = GetDesiredVerses(packs, CustomVerses);
            string translation = SelectedTranslationName();
			mainPanel.Controls.Add(new ReviewVerses(versesToReview, translation));
		}

		public static void MatchVersesHandler(List<VersePack> CustomVerses, List<string> packs, bool verseToReference, object sender)
        {
            mainPanel.Controls.Remove((Control)sender);
			List<Verse> versesToReview = GetDesiredVerses(packs, CustomVerses);
			List<Verse> versesToMatchAgainst = new List<Verse>();

			foreach (VersePack vp in AllVerses)
			{
				foreach (Verse v in vp.Verses)
				{
					versesToMatchAgainst.Add(v);
				}
			}
			foreach (VersePack vp in CustomVerses)
			{
				foreach (Verse v in vp.Verses)
				{
					versesToMatchAgainst.Add(v);
				}
			}

			mainPanel.Controls.Add(new MatchVerses(versesToReview, SelectedTranslationName(), verseToReference, versesToMatchAgainst));
        }

		public static void LearnVersesHandler(List<VersePack> CustomVerses, List<string> packs, object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
			List<Verse> versesToReview = GetDesiredVerses(packs, CustomVerses);
			mainPanel.Controls.Add(new LearnVerses(versesToReview));
		}

		private static List<Verse> GetDesiredVerses(List<string> packs, List<VersePack> CustomVerses)
        {
            List<Verse> versesToReview = new List<Verse>();
			foreach (VersePack vp in AllVerses)
            {
				if (packs.Contains(vp.Name))
				{
					foreach (Verse v in vp.Verses)
					{
						versesToReview.Add(v);
					}
				}
            }
			foreach (VersePack vp in CustomVerses)
            {
				if (packs.Contains(vp.Name))
                {
                    foreach (Verse v in vp.Verses)
                    {
                        if (!versesToReview.Contains(v))
                        {
                            versesToReview.Add(v);
                        }
                    }
                }
            }
			foreach (Verse v in versesToReview)
			{
				v.setTranslation(SelectedTranslationName());
			}
            return versesToReview;
        }

		private static List<VersePack> ReadInVerses()
		{
			List<VersePack> verses = new List<VersePack>();
			verses.Add(TMSVerses.A_PACK());
			verses.Add(TMSVerses.B_PACK());
			verses.Add(TMSVerses.C_PACK());
			verses.Add(TMSVerses.D_PACK());
			verses.Add(TMSVerses.E_PACK());
			return verses;
		}

		private void MainMenuStripClick(object sender, EventArgs e)
		{
			while (mainPanel.Controls.Count > 0)
			{
				mainPanel.Controls.RemoveAt(0);
			}
			mainPanel.Controls.Add(new MainMenuPanel());
		}

        public static void ViewVerseInContext(Verse v, string translation)
        {
            string verse = v.getVerseNumbers().Split(',')[0];
            string url = "";
			if (biblijaToolStripMenuItem.Checked)
			{
				//URL: http://www.biblija.net/biblija.cgi?m=galatians+2&id42=0&id18=1&pos=0&l=nl&set=10
				url = "http://www.biblija.net/biblija.cgi?m=" + v.getNbvBook() + "+" + v.getChapter().ToString() + 
					"&id42=0&id18=1&pos=0&l=nl&set=10";
			}
			else if (bibleGatewayToolStripMenuItem.Checked)
			{
				//URL: http://www.biblegateway.com/passage/?search=1 peter 3&version=NIV
				url = "http://www.biblegateway.com/passage/?search=" + v.getBook() + " " + v.getChapter().ToString() +
					"&version=" + translation;
			}
			else if (esvOnlineStudyBibleToolStripMenuItem.Checked)
			{
				//URL: http://www.esvstudybible.org/search?q=1+peter+3
				url = "http://www.esvstudybible.org/search?q=" + v.getBook().Replace(" ", "+") + " " + v.getChapter();
			}
			else
			{
				//URL: http://www.blueletterbible.org/Bible.cfm?b=1 Peter&c=5&v=7&t=NIV#7
				url = "http://www.blueletterbible.org/Bible.cfm?b=" + v.getBook() + "&c=" + v.getChapter().ToString() +
				"&v=" + verse + "&t=" + translation + "#" + verse;
			}
            bool openInApplication = openBibleInApplicationToolStripMenuItem.Checked;
            if (openInApplication)
            {
                mainPanel.Controls.Add(new ViewInContextPanel(url));
                //disable other controls so the one we just added is visible
                foreach (Control c in mainPanel.Controls)
                {
                    if (!(c is ViewInContextPanel))
                    {
                        c.Visible = false;
                    }
                }
            }
            else
            {
                System.Diagnostics.Process.Start(url);
            }
        }

        public static void CloseVerseInContext(object sender)
        {
            mainPanel.Controls.Remove((Control)sender);
            mainPanel.Controls[0].Visible = true;
        }

        public static string SelectedTranslationName()
        {
            string translation = "";
            bool found = false;
            int i = 0;
            while (!found && i < translationToolStripMenuItem.DropDownItems.Count)
            {
                if (((ToolStripMenuItem)translationToolStripMenuItem.DropDownItems[i]).Checked)
                {
                    found = true;
                    translation = translationToolStripMenuItem.DropDownItems[i].Tag.ToString();
                }
                i++;
            }
            return translation;
        }

        public static string SelectedVoiceName()
        {
            string voice = "";
            bool found = false;
            int i = 0;
            while (!found && i < voiceToolStripMenuItem.DropDownItems.Count)
            {
                if (((ToolStripMenuItem)voiceToolStripMenuItem.DropDownItems[i]).Checked)
                {
                    found = true;
                    voice = voiceToolStripMenuItem.DropDownItems[i].Name;
                }
                i++;
            }
            return voice;
        }

        private void BibleSelected(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                int i = 0;
                while (i < onlineBibleToolStripMenuItem.DropDownItems.Count)
                {
                    ToolStripMenuItem item = null;
                    try
                    {
                        item = (ToolStripMenuItem)onlineBibleToolStripMenuItem.DropDownItems[i];
                    } catch (InvalidCastException exception)
                    {	//need because of tool strip separators
                        exception.ToString();
                    }
                    if (item != null && item.Tag.ToString().Equals(((ToolStripMenuItem)sender).Tag.ToString()))
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
                    i++;
                }
            }
        }

        private void addVerseToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MessageBox.Show("This feature is temporarily disabled.");
            //AddCustomVerses obj = new AddCustomVerses(LoadCustomVerses());
            //obj.Show();
        }

        private void editCustomVersesToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MessageBox.Show("This feature is temporarily disabled.");
			//EditCustomVerses obj = new EditCustomVerses(LoadCustomVerses());
            //obj.Show();
        }
	}
}
