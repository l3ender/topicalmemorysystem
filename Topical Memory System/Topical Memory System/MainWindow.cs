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
        {
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
					}
					if ((item != null) && (item != sender))
					{
						item.Checked = false;
					}
				}
			}
            int translation = 0;
            if (esvStripMenuItem.Checked)
            {
                translation = 1;
            }
            if (mainPanel.Controls.Count > 0)
            {
                if (mainPanel.Controls[0] is ReviewVerses)
                {
                    ReviewVerses.ChangeTranslation(translation);
                }
                else if (mainPanel.Controls[0] is MatchVerses)
                {
                    MatchVerses.ChangeTranslation(translation);
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

		public static void ReviewVersesHandler(object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
			mainPanel.Controls.Add(new ReviewVersesOptionsPanel("review"));
		}

        public static void MatchVersesHandler(object sender)
        {
            mainPanel.Controls.Remove((Control)sender);
            mainPanel.Controls.Add(new MatchVersesOptionPanel());
        }

        public static void MatchVersesHandler(object sender, bool verseToReference)
        {
            mainPanel.Controls.Remove((Control)sender);
            if (verseToReference)
            {
                mainPanel.Controls.Add(new ReviewVersesOptionsPanel("vr"));
            }
            else
            {
                mainPanel.Controls.Add(new ReviewVersesOptionsPanel("rv"));
            }
        }

		public static void ReviewVersesHandler(List<string> packs, object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
            List<Verse> versesToReview = ReadInDesiredVerses(packs);
            string translation = SelectedTranslationName();
			Hashtable topics = ReadInTopics();
			mainPanel.Controls.Add(new ReviewVerses(versesToReview, translation, topics));
		}

        public static void MatchVersesHandler(List<string> packs, bool verseToReference, object sender)
        {
            mainPanel.Controls.Remove((Control)sender);
            List<Verse> versesToReview = ReadInDesiredVerses(packs);
            string translation = SelectedTranslationName();
            Hashtable topics = ReadInTopics();

            mainPanel.Controls.Add(new MatchVerses(versesToReview, translation, topics, verseToReference));
        }

        private static List<Verse> ReadInDesiredVerses(List<string> packs)
        {
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
            return versesToReview;
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

        public static void ViewVerseInContext(Verse v, string translation)
        {
            string verse = v.getVerseNumbers().Split(',')[0];
            string url = "";
            if (bibleGatewayToolStripMenuItem.Checked)
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
                    {
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
	}
}
