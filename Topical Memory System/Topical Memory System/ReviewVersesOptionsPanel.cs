using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace Topical_Memory_System
{
	public partial class ReviewVersesOptionsPanel : UserControl
	{
        private string caller;
        private List<VersePack> CustomVerses;

		public ReviewVersesOptionsPanel(string incomingCaller, List<VersePack> IncomingCustomVerses)
		{
			InitializeComponent();
            this.CustomVerses = IncomingCustomVerses;
			VersePackListBox.Items.Add("A - Live The New Life");
			VersePackListBox.Items.Add("B - Proclaim Christ");
			VersePackListBox.Items.Add("C - Rely On God's Resources");
			VersePackListBox.Items.Add("D - Be Christ's Disciple");
			VersePackListBox.Items.Add("E - Grow In Christlikeness");
			VersePackListBox.SelectedIndex = 0;		//default to selecting A pack
			foreach (VersePack vp in CustomVerses)
            {
				if (vp.Verses.Count > 0)
				{
					VersePackListBox.Items.Add(vp.Name);
				}
            }
            this.caller = incomingCaller;
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			List<string> packs = new List<string>();
			for (int i = 0; i < VersePackListBox.Items.Count; i++)
			{
				if (VersePackListBox.SelectedIndices.Contains(i))
				{
					packs.Add((string)VersePackListBox.Items[i]);
				}
			}
            if (caller.Equals("review"))
            {
				MenuExit.ReviewVersesHandler(CustomVerses, packs, this);
            }
            else if (caller.Equals("vr"))
            {
				MenuExit.MatchVersesHandler(CustomVerses, packs, true, this);
            }
            else if (caller.Equals("rv"))
            {
				MenuExit.MatchVersesHandler(CustomVerses, packs, false, this);
			}
			else if (caller.Equals("learn"))
			{
				MenuExit.LearnVersesHandler(CustomVerses, packs, this);
			}
		}
	}
}
