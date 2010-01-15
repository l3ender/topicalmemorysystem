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
        private Hashtable CustomVerses;

        public ReviewVersesOptionsPanel(string incomingCaller, Hashtable IncomingCustomVerses)
		{
			InitializeComponent();
            this.CustomVerses = IncomingCustomVerses;
            List<CheckBox> checks = GetOrderedCheckBoxes(CustomVerses.Count);
            foreach (DictionaryEntry obj in CustomVerses)
            {
				if (((List<Verse>)obj.Value).Count > 0)
				{
					CheckBox c = checks[0];
					checks.RemoveAt(0);
					c.Visible = true;
					c.Text = ((string)obj.Key).Split('~')[1];
				}
            }
            this.caller = incomingCaller;
            allPacksCheck.Checked = true;
		}

        private List<CheckBox> GetOrderedCheckBoxes(int numChecks)
        {
            List<CheckBox> checks = new List<CheckBox>(numChecks);
            if (numChecks == 1)
            {
                checks.Add(custom3Check);
            }
            else if (numChecks == 2)
            {
                checks.Add(custom1Check);
                checks.Add(custom2Check);
            }
            else if (numChecks == 3)
            {
                checks.Add(custom1Check);
                checks.Add(custom2Check);
                checks.Add(custom3Check);
            }
            else if (numChecks == 4)
            {
                checks.Add(custom1Check);
                checks.Add(custom2Check);
                checks.Add(custom4Check);
                checks.Add(custom5Check);
            }
            else if (numChecks == 5)
            {
                checks.Add(custom1Check);
                checks.Add(custom2Check);
                checks.Add(custom3Check);
                checks.Add(custom4Check);
                checks.Add(custom5Check);
            }
            return checks;
        }

		private void CheckBoxClicked(object sender, EventArgs e)
		{
			if (((CheckBox)sender).Name.ToString().Equals("allPacksCheck"))
			{
				if (((CheckBox)sender).Checked)
				{
					//disable all the others
					aPackCheck.Checked = false;
					bPackCheck.Checked = false;
					cPackCheck.Checked = false;
					dPackCheck.Checked = false;
					ePackCheck.Checked = false;
                    custom1Check.Checked = false;
                    custom2Check.Checked = false;
                    custom3Check.Checked = false;
                    custom4Check.Checked = false;
                    custom5Check.Checked = false;
				}
			}
			else
			{
				if (((CheckBox)sender).Checked)
				{
					allPacksCheck.Checked = false;
				}
			}
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			List<string> packs = new List<string>();
			if (allPacksCheck.Checked)
			{
				packs.Add("all");
			}
			else
			{
				if (aPackCheck.Checked)
				{
					packs.Add("A");
				}
				if (bPackCheck.Checked)
				{
					packs.Add("B");
				}
				if (cPackCheck.Checked)
				{
					packs.Add("C");
				}
				if (dPackCheck.Checked)
				{
					packs.Add("D");
				}
				if (ePackCheck.Checked)
				{
					packs.Add("E");
				}
                if (custom1Check.Checked)
                {
                    packs.Add("customVerses1");
                }
                if (custom2Check.Checked)
                {
                    packs.Add("customVerses2");
                }
                if (custom3Check.Checked)
                {
                    packs.Add("customVerses3");
                }
                if (custom4Check.Checked)
                {
                    packs.Add("customVerses4");
                }
                if (custom5Check.Checked)
                {
                    packs.Add("customVerses5");
                }
			}
			//defaults to all
			if (packs.Count == 0)
			{
				packs.Add("all");
			}
            if (caller.Equals("review"))
            {
                MenuExit.ReviewVersesHandler(packs, this);
            }
            else if (caller.Equals("vr"))
            {
                MenuExit.MatchVersesHandler(packs, true, this);
            }
            else if (caller.Equals("rv"))
            {
                MenuExit.MatchVersesHandler(packs, false, this);
			}
			else if (caller.Equals("learn"))
			{
				MenuExit.LearnVersesHandler(packs, this);
			}
		}
	}
}
