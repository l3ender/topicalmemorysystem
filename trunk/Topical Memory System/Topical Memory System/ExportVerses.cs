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

		public ExportVerses(List<VersePack> CustomVerses)
		{
			InitializeComponent();
			this.CustomVerses = CustomVerses;
			foreach (VersePack vp in CustomVerses)
			{
				VersePackBox.Items.Add(vp.Name);
			}
		}

		private void VersePackSelected(object sender, EventArgs e)
		{
			if (VersePackBox.SelectedIndex > -1)
			{
				VersesBox.Items.Clear();
				foreach (VersePack vp in CustomVerses)
				{
					if (vp.Name == VersePackBox.Text)
					{
						SelectedVersePack = vp;
						foreach (Verse v in SelectedVersePack.Verses)
						{
							if (!SelectedVersesBox.Items.Contains(v.getReference()))
							{
								VersesBox.Items.Add(v.getReference());
							}
						}
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
			SaveButton.Enabled = true;
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
			SaveButton.Enabled = true;
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
				SaveButton.Enabled = false;
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
			SaveButton.Enabled = false;
			RemoveAllButton.Enabled = false;
		}

		private void SaveButton_Click(object sender, EventArgs e)
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
						if (SelectedVersesBox.Items.Contains(v.getReference()))
						{
							sb.Append(v.getBook());
							sb.Append(Constants.FileDelimiter);
							sb.Append(v.getChapter());
							sb.Append(Constants.FileDelimiter);
							sb.Append(v.getVerseNumbers());
							sb.Append(Constants.FileDelimiter);
							sb.Append(v.getVerseData());
							sb.Append(Constants.NewLine);
						}
					}
				}
				File.WriteAllText(dlg.FileName, sb.ToString());
			}
			this.Close();
		}
	}
}
