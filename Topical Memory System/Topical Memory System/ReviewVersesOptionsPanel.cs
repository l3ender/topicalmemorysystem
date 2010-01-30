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
			VersePackListBox.Items.Add(TMSVerses.A_PACK());
			VersePackListBox.Items.Add(TMSVerses.B_PACK());
			VersePackListBox.Items.Add(TMSVerses.C_PACK());
			VersePackListBox.Items.Add(TMSVerses.D_PACK());
			VersePackListBox.Items.Add(TMSVerses.E_PACK());
			VersePackListBox.SelectedIndex = 0;		//default to selecting A pack
			foreach (VersePack vp in CustomVerses)
            {
				if (vp.Verses.Count > 0)
				{
					VersePackListBox.Items.Add(vp);
				}
            }
            this.caller = incomingCaller;
			//if we are matching, don't display the random option-- it should always be random
			if (incomingCaller == "vr" || incomingCaller == "rv")
			{
				RandomCheckbox.Visible = false;
			}
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			List<VersePack> packs = new List<VersePack>();
			for (int i = 0; i < VersePackListBox.Items.Count; i++)
			{
				if (VersePackListBox.SelectedIndices.Contains(i))
				{
					packs.Add((VersePack)VersePackListBox.Items[i]);
				}
			}
            if (caller.Equals("review"))
            {
				MenuExit.ReviewVersesHandler(packs, RandomCheckbox.Checked, this);
            }
            else if (caller.Equals("vr"))
            {
				MenuExit.MatchVersesHandler(packs, true, true, this);
            }
            else if (caller.Equals("rv"))
            {
				MenuExit.MatchVersesHandler(packs, true, false, this);
			}
			else if (caller.Equals("learnReferences"))
			{
				MenuExit.LearnVersesHandler(packs, RandomCheckbox.Checked, true, this);
			}
			else if (caller.Equals("learnVerses"))
			{
				MenuExit.LearnVersesHandler(packs, RandomCheckbox.Checked, false, this);
			}
		}
	}
}
