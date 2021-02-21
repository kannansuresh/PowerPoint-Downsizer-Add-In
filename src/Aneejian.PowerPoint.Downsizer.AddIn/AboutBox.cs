using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    public partial class AboutBox : Form
    {
        private readonly Properties.Settings _settings = Properties.Settings.Default;

        public AboutBox()
        {
            InitializeComponent();
            Text = string.Format("About {0}", _settings.App_Name);
            labelProductName.Text = _settings.App_Name;
            labelVersion.Text = string.Format("Version {0}", _settings.App_Version.Replace("v", ""));
            labelCopyright.Text = _settings.App_Copyright;
            labelCompanyName.Text = _settings.App_Company;
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
            //Properties.Settings.Default.Reset();
            _ = Task.Run(() => _ = new UpdateChecker().CheckForUpdates());
            ActiveForm.Close();
        }
    }
}