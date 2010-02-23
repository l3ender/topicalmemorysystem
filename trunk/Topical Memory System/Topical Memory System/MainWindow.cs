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
using System.Data.SQLite;
using System.Configuration;
using System.Threading;
using System.Xml;
using System.Net;

namespace Topical_Memory_System
{
	public partial class MenuExit : Form
	{
		private static Database db;
		private static List<VersePack> AllVerses;
		private static List<VersePack> CustomVerses;

		private static List<VoiceInfo> AvailableVoices;
		public static string SelectedVoiceName;
		public static int SelectedVoiceSpeed;

		public MenuExit()
		{
			InitializeComponent();
			db = new Database();
			AllVerses = ReadInVerses();
			try
			{
				CustomVerses = LoadCustomVerses();
			}
			catch (Exception)
			{
				CustomVerses = new List<VersePack>();
				MessageBox.Show("A problem occurred while loading custom verses.");
				customVersesToolStripMenuItem.Enabled = false;
			}
			InstallSystemVoices();
            AddAboutStrip();    //add this last manually so it is the right-most strip
			mainPanel.Controls.Add(new MainMenuPanel());
			mainPanel.Refresh();
		}

		/******************************* Start Database Methods *******************************/
		public static List<VersePack> LoadCustomVerses()
		{
			CustomVerses = db.LoadCustomVerses();
			if (CustomVerses == null)
			{
				CustomVerses = new List<VersePack>();
			}
			return CustomVerses;
		}
		public static void UpdateVerse(Verse oldVerse, Verse newVerse)
		{
			db.UpdateVerse(oldVerse, newVerse);
			CustomVerses = LoadCustomVerses();
		}
		public static void UpdateGroupName(string oldName, string newName)
		{
			db.UpdateGroupName(oldName, newName);
			CustomVerses = LoadCustomVerses();
		}
		public static void DeleteVerse(Verse oldVerse)
		{
			db.DeleteVerse(oldVerse);
			CustomVerses = LoadCustomVerses();
		}
		public static void DeleteGroupName(string name)
		{
			db.DeleteGroupName(name);
			CustomVerses = LoadCustomVerses();
		}
		public static List<string> LoadCustomGroupNames()
		{
			try
			{
				return db.LoadCustomGroupNames();
			}
			catch (Exception)
			{
				return new List<string>();
			}
		}
		public static void SaveMultipleVersesToDatabase(List<Verse> verses, string groupName)
		{
			db.SaveMultipleVersesToDatabase(verses, groupName);
			CustomVerses = LoadCustomVerses();
		}
		public static void SaveVerseToDatabase(string book, int chapter, string verseNumbers, string verseData, string groupName)
		{
			db.SaveVerseToDatabase(book, chapter, verseNumbers, verseData, groupName);
			CustomVerses = LoadCustomVerses();
		}
		public static void CreateGroup(string groupName)
		{
			db.CreateGroup(groupName);
			CustomVerses = LoadCustomVerses();
		}
		/******************************* End Database Methods *******************************/


		private void CheckForUpdate(object sender, EventArgs e)
		{
			UpdateChecker.CheckForUpdate();
		}

		public static List<VersePack> CopyVersePackList(List<VersePack> oldList)
		{	//deep copy for lists
			List<VersePack> newList = new List<VersePack>();
			foreach (VersePack vp in oldList)
			{
				newList.Add(vp);
			}
			return newList;
		}

        private void InstallSystemVoices()
        {
            //get the installed voices on the system
            SpeechSynthesizer speechSynth = new SpeechSynthesizer();
            var listOfVoiceInfo = from voice
                                      in speechSynth.GetInstalledVoices(CultureInfo.CurrentCulture)
                                  select voice.VoiceInfo;
            AvailableVoices = listOfVoiceInfo.ToList<VoiceInfo>();
			if (AvailableVoices.Count > 0)
			{
				SelectedVoiceName = AvailableVoices[0].Name;
				SelectedVoiceSpeed = -2;
			}
        }

        private void AddAboutStrip()
        {	//done so that it is on the furthest right of the strip
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.Items.Add(aboutToolStripMenuItem);

			ToolStripMenuItem checkForUpdatesStrip = new System.Windows.Forms.ToolStripMenuItem();
			checkForUpdatesStrip.Name = "checkForUpdatesStrip";
			checkForUpdatesStrip.Size = new System.Drawing.Size(237, 22);
			checkForUpdatesStrip.Text = "Check for update";
			checkForUpdatesStrip.Click += new System.EventHandler(this.CheckForUpdate);
			aboutToolStripMenuItem.DropDownItems.Add(checkForUpdatesStrip);

			aboutToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());

            ToolStripMenuItem infoStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            infoStripMenuItem.Name = "infoStripMenuItem";
            infoStripMenuItem.Size = new System.Drawing.Size(237, 22);
            infoStripMenuItem.Text = "Project homepage";
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
				else if (mainPanel.Controls[0] is LearnReferences)
				{
					LearnReferences.ChangeTranslation(SelectedTranslationName());
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
            ab.ShowDialog();
        }

		public static void ViewVersesHandler(object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
			List<VersePack> verses = CopyVersePackList(AllVerses);
			foreach (VersePack vp in CustomVerses)
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
			mainPanel.Controls.Add(new ReviewVersesOptionsPanel("review", CustomVerses));
		}

        public static void MatchVersesHandler(object sender)
        {
            mainPanel.Controls.Remove((Control)sender);
            mainPanel.Controls.Add(new MatchVersesOptionPanel());
        }

		public static void LearnVersesHandler(object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
			mainPanel.Controls.Add(new LearnVersesOptionPanel());
		}

        public static void MatchVersesHandler(object sender, bool verseToReference)
        {
            mainPanel.Controls.Remove((Control)sender);
            if (verseToReference)
            {
				mainPanel.Controls.Add(new ReviewVersesOptionsPanel("vr", CustomVerses));
            }
            else
            {
				mainPanel.Controls.Add(new ReviewVersesOptionsPanel("rv", CustomVerses));
            }
        }

		public static void ReviewVersesHandler(List<VersePack> packs, bool random, object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
			List<Verse> versesToReview = GetDesiredVerses(packs, random);
            string translation = SelectedTranslationName();
			mainPanel.Controls.Add(new ReviewVerses(versesToReview, translation));
		}

		public static void MatchVersesHandler(List<VersePack> packs, bool random, bool verseToReference, object sender)
        {
            mainPanel.Controls.Remove((Control)sender);
			List<Verse> versesToReview = GetDesiredVerses(packs, random);
			List<Verse> versesToMatchAgainst = new List<Verse>();

			//add all the verses so we can do some matching
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

		public static void LearnVersesHandler(object sender, bool learnReferences)
		{
			mainPanel.Controls.Remove((Control)sender);
			if (learnReferences)
			{
				mainPanel.Controls.Add(new ReviewVersesOptionsPanel("learnReferences", CustomVerses));
			}
			else
			{
				mainPanel.Controls.Add(new ReviewVersesOptionsPanel("learnVerses", CustomVerses));
			}
		}

		public static void LearnVersesHandler(List<VersePack> packs, bool random, bool learnReferences, object sender)
		{
			mainPanel.Controls.Remove((Control)sender);
			List<Verse> versesToReview = GetDesiredVerses(packs, random);
			if (learnReferences)
			{
				mainPanel.Controls.Add(new LearnReferences(versesToReview));
			}
			else
			{
				mainPanel.Controls.Add(new LearnVerses(versesToReview));
			}
		}

		private static List<Verse> GetDesiredVerses(List<VersePack> packs, bool random)
        {
            List<Verse> versesToReview = new List<Verse>();
			foreach (VersePack vp in packs)
            {
				foreach (Verse v in vp.Verses)
				{
					v.setTranslation(SelectedTranslationName());
					versesToReview.Add(v);
				}
            }
			if (random)
			{
				List<Verse> reviewVerses = new List<Verse>(versesToReview.Count);
				Random rand = new Random();
				while (versesToReview.Count > 0)
				{
					int rNum = rand.Next(versesToReview.Count);
					reviewVerses.Add(versesToReview[rNum]);
					versesToReview.RemoveAt(rNum);
				}
				return reviewVerses;
			}
			else
			{
				return versesToReview;
			}
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
				mainPanel.Controls[0].Dispose();
				//mainPanel.Controls.RemoveAt(0);
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

		public static bool VoiceAvailable()
		{
			return AvailableVoices.Count > 0;
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

		private void importVersesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (CustomVerses.Count > 0)
			{
				OpenFileDialog dlg = new OpenFileDialog();
				dlg.Multiselect = false;
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					try
					{
						ImportVerses iv = new ImportVerses(dlg.FileName, MenuExit.LoadCustomGroupNames());
						iv.ShowDialog();
					}
					catch (Exception)
					{
						MessageBox.Show("The verses could not be imported.");
					}
				}
			}
			else
			{
				MessageBox.Show("There are no custom groups!  You can add groups from the menu by selecting Custom Verses -> Add groups.");
			}
		}

		private void exportVersesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int numVerses = 0;
			foreach (VersePack vp in CustomVerses)
			{
				numVerses += vp.Verses.Count;
			}
			if (numVerses > 0)
			{
				ExportVerses ev = new ExportVerses(CustomVerses, false);
				ev.ShowDialog();
			}
			else
			{
				MessageBox.Show("You have no custom verses to export!");
			}
		}

		private void PrintVersesClick(object sender, EventArgs e)
		{
			ExportVerses ev = new ExportVerses(CustomVerses, true);
			ev.ShowDialog();
		}

		private static SpeechSynthesizer speaker = new SpeechSynthesizer();

		public static void TextToSpeech(string text, string name, int speed)
		{
			try
			{
				speaker.SelectVoice(name);
				speaker.Rate = speed;
				speaker.SpeakAsync(text);
			}
			catch (Exception)
			{
				MessageBox.Show("An error has occurred.  Please report the error to the project's administrator.");
			}
		}

		private void configureReadingVoicesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ConfigureVoices cv = new ConfigureVoices(AvailableVoices);
			cv.ShowDialog();
		}

		private void addVerseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> groupNames = MenuExit.LoadCustomGroupNames();
				if (groupNames.Count > 0)
				{
					AddCustomVerses obj = new AddCustomVerses(groupNames);
					obj.ShowDialog();
				}
				else
				{
					MessageBox.Show("There are no custom groups!  You can add groups from the menu by selecting Custom Verses -> Add groups.");
				}
			}
			catch (Exception)
			{
				MessageBox.Show("An error occurred accessing the custom verses.  This feature will be disabled.");
			}
		}

		private void editCustomVersesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int numVerses = 0;
			foreach (VersePack vp in CustomVerses)
			{
				numVerses += vp.Verses.Count;
			}
			if (numVerses > 0)
			{
				EditCustomVerses obj = new EditCustomVerses(CustomVerses);
				obj.ShowDialog();
			}
			else
			{
				MessageBox.Show("There are no custom verses!  You can add verses from the menu by selecting Custom Verses -> Add verses.");
			}
		}

		private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddCustomGroups acg = new AddCustomGroups(CustomVerses);
			acg.ShowDialog();
		}

		private void editGroupsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (CustomVerses.Count > 0)
			{
				EditCustomGroups ecg = new EditCustomGroups(CustomVerses);
				ecg.ShowDialog();
			}
			else
			{
				MessageBox.Show("There are no custom groups!  You can add groups from the menu by selecting Custom Verses -> Add groups.");
			}
		}
	}
}
