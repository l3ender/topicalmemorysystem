using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Topical_Memory_System
{
	public partial class ExportVerses : Form
	{
		private List<VersePack> CustomVerses;
		private VersePack SelectedVersePack;
		private bool isPrint;

		public ExportVerses(List<VersePack> CustomVerses, bool incomingIsPrint)	//class can be used for printing verses or saving to file
		{
			InitializeComponent();
			this.CustomVerses = CustomVerses;
			foreach (VersePack vp in CustomVerses)
			{
				if (vp.Verses.Count > 0)
				{
					VersePackBox.Items.Add(vp);
				}
			}
			this.isPrint = incomingIsPrint;
			if (isPrint)
			{
				VersePackBox.Items.Add(TMSVerses.A_PACK());
				VersePackBox.Items.Add(TMSVerses.B_PACK());
				VersePackBox.Items.Add(TMSVerses.C_PACK());
				VersePackBox.Items.Add(TMSVerses.D_PACK());
				VersePackBox.Items.Add(TMSVerses.E_PACK());
				SaveAllButton.Text = "Print all verses";
				SaveSelectedButton.Text = "Print selected verses";
				label6.Text = "Verses to print";
				this.Text = "Print Custom Verses";
			}
		}

		private void VersePackSelected(object sender, EventArgs e)
		{
			if (VersePackBox.SelectedIndex > -1)
			{
				VersesBox.Items.Clear();
				SelectedVersePack = (VersePack)VersePackBox.SelectedItem;
				foreach (Verse v in SelectedVersePack.Verses)
				{
					if (!SelectedVersesBox.Items.Contains(v.getReference()))
					{
						VersesBox.Items.Add(v.getReference());
					}
				}
				AddAllButton.Enabled = true;
				AddVerseButton.Enabled = false;
			}
		}

		private void VerseSelected(object sender, EventArgs e)
		{
			if (VersesBox.SelectedIndex > -1)
			{
				AddVerseButton.Enabled = true;
			}
		}

		private void AddVerseButton_Click(object sender, EventArgs e)
		{
			foreach (object obj in VersesBox.SelectedItems)
			{
				SelectedVersesBox.Items.Add((string)obj);
			}
			foreach (object obj in SelectedVersesBox.Items)
			{
				if (VersesBox.Items.Contains((string)obj))
				{
					VersesBox.Items.Remove((string)obj);
				}
			}
			AddVerseButton.Enabled = false;
			RemoveAllButton.Enabled = true;
			SaveSelectedButton.Enabled = true;
		}

		private void AddAllButton_Click(object sender, EventArgs e)
		{
			foreach (object obj in VersesBox.Items)
			{
				SelectedVersesBox.Items.Add((string)obj);
			}
			//remove verses from selection box
			VersesBox.Items.Clear();
			RemoveAllButton.Enabled = true;
			SaveSelectedButton.Enabled = true;
			AddAllButton.Enabled = false;
		}

		private void SelectedFromTotalBox(object sender, EventArgs e)
		{
			if (SelectedVersesBox.SelectedIndex > -1)
			{
				RemoveVerseButton.Enabled = true;
			}
		}

		private void RemoveVerseButton_Click(object sender, EventArgs e)
		{
			object[] items = new object[SelectedVersesBox.SelectedItems.Count];
			SelectedVersesBox.SelectedItems.CopyTo(items, 0);
			foreach (object obj in items)
			{
				SelectedVersesBox.Items.Remove((string)obj);
			}
			VersePackSelected(null, null);	//this refreshes verses box
			if (SelectedVersesBox.Items.Count < 1)
			{
				SaveSelectedButton.Enabled = false;
				RemoveAllButton.Enabled = false;
			}
			RemoveVerseButton.Enabled = false;
		}

		private void RemoveAllButton_Click(object sender, EventArgs e)
		{
			object[] items = new object[SelectedVersesBox.Items.Count];
			SelectedVersesBox.Items.CopyTo(items, 0);
			foreach (object obj in items)
			{
				SelectedVersesBox.Items.Remove((string)obj);
			}
			VersePackSelected(null, null);	//this refreshes verses box
			SaveSelectedButton.Enabled = false;
			RemoveAllButton.Enabled = false;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (isPrint)
			{
				string selection = GetOption();
				panel1.Enabled = false;
				PrintingBox.Visible = true;
				List<Verse> verses = AddVerses(false);
				PrintVerses.Print(verses, selection);
			}
			else
			{
				SaveFileDialog dlg = new SaveFileDialog();
				dlg.FileName = "Custom Verses.txt";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					StringBuilder sb = new StringBuilder("");
					foreach (VersePack vp in CustomVerses)
					{
						foreach (Verse v in vp.Verses)
						{
							if (SelectedVersesBox.Items.Contains(v.getReference()))
							{
								sb.Append(v.getBook());
								sb.Append(Constants.FileDelimiter);
								sb.Append(v.getChapter());
								sb.Append(Constants.FileDelimiter);
								sb.Append(v.getVerseNumbers());
								sb.Append(Constants.FileDelimiter);
								string verseData = v.getVerseData();
								if (verseData.Contains("\r\n"))
								{
									verseData = verseData.Replace("\r\n", " ");
								}
								if (verseData.Contains("\r"))
								{
									verseData = verseData.Replace("\r", " ");
								}
								if (verseData.Contains("\n"))
								{
									verseData = verseData.Replace("\n", " ");
								}
								sb.Append(verseData);
								sb.Append(Constants.NewLine);
							}
						}
					}
					File.WriteAllText(dlg.FileName, sb.ToString());
				}
			}
			this.Close();
		}

		private void SaveAllButton_Click(object sender, EventArgs e)
		{
			if (isPrint)
			{
				string selection = GetOption();
				panel1.Enabled = false;
				PrintingBox.Visible = true;
				List<Verse> verses = AddVerses(true);
				PrintVerses.Print(verses, selection);
			}
			else
			{
				SaveFileDialog dlg = new SaveFileDialog();
				dlg.FileName = "Custom_Verses.txt";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					StringBuilder sb = new StringBuilder("");
					foreach (VersePack vp in CustomVerses)
					{
						foreach (Verse v in vp.Verses)
						{
							sb.Append(v.getBook());
							sb.Append(Constants.FileDelimiter);
							sb.Append(v.getChapter());
							sb.Append(Constants.FileDelimiter);
							sb.Append(v.getVerseNumbers());
							sb.Append(Constants.FileDelimiter);
							string verseData = v.getVerseData();
							if (verseData.Contains("\r\n"))
							{
								verseData = verseData.Replace("\r\n", " ");
							}
							if (verseData.Contains("\r"))
							{
								verseData = verseData.Replace("\r", " ");
							}
							if (verseData.Contains("\n"))
							{
								verseData = verseData.Replace("\n", " ");
							}
							sb.Append(verseData);
							sb.Append(Constants.NewLine);
						}
					}
					File.WriteAllText(dlg.FileName, sb.ToString());
				}
			}
			this.Close();
		}

		private string GetOption()
		{
			PrintOptions po = new PrintOptions();
			//DialogResult.No;			//just references
			//DialogResult.Ignore;		//just verses
			//DialogResult.Yes;			//both
			string selection = "both";
			DialogResult dr = po.ShowDialog();
			if (dr == DialogResult.No)
			{
				selection = "references";
			}
			else if (dr == DialogResult.Ignore)
			{
				selection = "verses";
			}
			else if (dr == DialogResult.Yes)
			{
				selection = "both";
			}
			return selection;
		}

		private List<Verse> AddVerses(bool addAll)
		{
			List<Verse> verses = new List<Verse>();
			foreach (VersePack vp in CustomVerses)
			{
				foreach (Verse v in vp.Verses)
				{
					if (addAll)
					{
						verses.Add(v);
					}
					else
					{
						if (SelectedVersesBox.Items.Contains(v.getReference()))
						{
							verses.Add(v);
						}
					}
				}
			}
			foreach (Verse v in TMSVerses.A_PACK().Verses)
			{
				if (addAll)
				{
					verses.Add(v);
				}
				else
				{
					if (SelectedVersesBox.Items.Contains(v.getReference()))
					{
						verses.Add(v);
					}
				}
			}
			foreach (Verse v in TMSVerses.B_PACK().Verses)
			{
				if (addAll)
				{
					verses.Add(v);
				}
				else
				{
					if (SelectedVersesBox.Items.Contains(v.getReference()))
					{
						verses.Add(v);
					}
				}
			}
			foreach (Verse v in TMSVerses.C_PACK().Verses)
			{
				if (addAll)
				{
					verses.Add(v);
				}
				else
				{
					if (SelectedVersesBox.Items.Contains(v.getReference()))
					{
						verses.Add(v);
					}
				}
			}
			foreach (Verse v in TMSVerses.D_PACK().Verses)
			{
				if (addAll)
				{
					verses.Add(v);
				}
				else
				{
					if (SelectedVersesBox.Items.Contains(v.getReference()))
					{
						verses.Add(v);
					}
				}
			}
			foreach (Verse v in TMSVerses.E_PACK().Verses)
			{
				if (addAll)
				{
					verses.Add(v);
				}
				else
				{
					if (SelectedVersesBox.Items.Contains(v.getReference()))
					{
						verses.Add(v);
					}
				}
			}
			return verses;
		}
	}
}
