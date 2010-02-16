using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

namespace Topical_Memory_System
{
	public partial class ConfigureVoices : Form
	{
		private List<VoiceInfo> AvailableVoices;
		public ConfigureVoices(List<VoiceInfo> IncomingAvailableVoices)
		{
			InitializeComponent();
			this.AvailableVoices = IncomingAvailableVoices;
			foreach (VoiceInfo vi in AvailableVoices)
			{
				VoicesDropDown.Items.Add(vi.Name);
			}
			if (VoicesDropDown.Items.Count > 0)
			{
				VoicesDropDown.SelectedItem = MenuExit.SelectedVoiceName;
				SoundBar.Value = MenuExit.SelectedVoiceSpeed;
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			MenuExit.SelectedVoiceName = VoicesDropDown.Text;
			MenuExit.SelectedVoiceSpeed = SoundBar.Value;
			this.Close();
		}

		private void TrySettingsButton_Click(object sender, EventArgs e)
		{
			MenuExit.TextToSpeech("John 3:30.  He must increase, but I must decrease.", VoicesDropDown.Text, SoundBar.Value);
		}
	}
}
