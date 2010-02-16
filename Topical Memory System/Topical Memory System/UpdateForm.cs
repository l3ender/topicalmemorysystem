using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Topical_Memory_System
{
	public partial class UpdateForm : Form
	{
		private string downloadUrl;
		public UpdateForm(bool updateNeeded, string incomingDownloadUrl)
		{
			InitializeComponent();
			this.downloadUrl = incomingDownloadUrl;
			if (this.downloadUrl == null || this.downloadUrl.Trim() == "")
			{
				this.downloadUrl = "http://code.google.com/p/topicalmemorysystem/";
			}
			if (updateNeeded)
			{
				LinkLabel.Visible = true;
				DisplayBox.Text = "A new version is available! Click here to download.";
			}
			else
			{
				LinkLabel.Visible = false;
				DisplayBox.Text = "Congratulations! You are using the latest version!";
			}
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(downloadUrl);
			this.Close();
		}
	}
}
