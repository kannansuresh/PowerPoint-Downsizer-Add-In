using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using appInfo = Aneejian.PowerPoint.Downsizer.AddIn.Fickles.AppInfo;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            Text = string.Format("About {0}", appInfo.Title);
            labelProductName.Text = appInfo.Product;
            labelVersion.Text = string.Format("Version {0}", appInfo.Version.Replace("v", ""));
            labelCopyright.Text = appInfo.Copyright;
            labelCompanyName.Text = appInfo.Company;
            rtbUsageStats.Text = new UsageStats().ToString();
        }

        private async void AneejianLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await Performer.HomePage().ConfigureAwait(false);
            ActiveForm.Close();
        }

        private async void BmcLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await Performer.Coffee().ConfigureAwait(false);
            ActiveForm.Close();
        }

        private void LogoBox_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            _ = Task.Run(() => Reporter.ReportUsageStats()).ConfigureAwait(false);
        }
    }
}