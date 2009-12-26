using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Topical_Memory_System
{
    public partial class ViewInContextPanel : UserControl
    {
        public ViewInContextPanel(string url)
        {
            InitializeComponent();
            MenuExit.loadingBox.Visible = true;
            webBrowser.Navigate(url);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            MenuExit.CloseVerseInContext(this);
        }

        private void ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress.Equals(e.MaximumProgress))
            {
                MenuExit.loadingBox.Visible = false;
            }
        }
    }
}
