using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    public partial class DownsizerRibbon
    {
        private void DownsizerRibbon_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private async void BtnDownsizeSlideMaster_Click(object sender, RibbonControlEventArgs e)
        {
            await PerformAction.DownSize().ConfigureAwait(false);
        }

        private async void BtnHelp_Click(object sender, RibbonControlEventArgs e)
        {
            await PerformAction.Help().ConfigureAwait(false);
        }

        private async void BtnDonate_Click(object sender, RibbonControlEventArgs e)
        {
            await PerformAction.Donate().ConfigureAwait(false);
        }

        private async void BtnGetDownsizePotential_Click(object sender, RibbonControlEventArgs e)
        {
            await PerformAction.GetPotential().ConfigureAwait(false);
        }

        private void BtnHideDownsizerTab_Click(object sender, RibbonControlEventArgs e)
        {
            PerformAction.UnhideOrHideTab();
        }

        private async void BtnDownsizeInView_Click(object sender, RibbonControlEventArgs e)
        {
            await PerformAction.DownSize().ConfigureAwait(false);
        }

        private async void BtnPotentionInView_Click(object sender, RibbonControlEventArgs e)
        {
            await PerformAction.GetPotential().ConfigureAwait(false);
        }

        private void BtnHideTabInView_Click(object sender, RibbonControlEventArgs e)
        {
            PerformAction.UnhideOrHideTab();
        }

        private async void BtnHelpInView_Click(object sender, RibbonControlEventArgs e)
        {
            await PerformAction.Help().ConfigureAwait(false);
        }

        private async void BtnDonateInView_Click(object sender, RibbonControlEventArgs e)
        {
            await PerformAction.Donate().ConfigureAwait(false);
        }

        private async void BtnDownsizeInViewMenu_Click(object sender, RibbonControlEventArgs e)
        {
            await PerformAction.DownSize().ConfigureAwait(false);
        }
    }
}