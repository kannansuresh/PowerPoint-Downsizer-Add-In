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
            await new SlideMasterDownsizer().Downsize(Globals.DownsizerAddIn.Application.ActivePresentation, Reporter.ReportDownsizeStatus).ConfigureAwait(false);
        }

        private async void BtnHelp_Click(object sender, RibbonControlEventArgs e)
        {
            await Task.FromResult(Process.Start(Fickles.HelpUrl)).ConfigureAwait(false);
        }

        private async void BtnDonate_Click(object sender, RibbonControlEventArgs e)
        {
            await Task.FromResult(Process.Start(Fickles.BuyCoffeeUrl)).ConfigureAwait(false);
        }

        private async void BtnGetDownsizePotential_Click(object sender, RibbonControlEventArgs e)
        {
            await new SlideMasterDownsizer().DownsizePotential(Globals.DownsizerAddIn.Application.ActivePresentation, Reporter.ReportDownsizePotential).ConfigureAwait(false);
        }

        private void BtnHideDownsizerTab_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.Ribbons.DownsizerRibbon.TabDownsizer.Visible = false;
        }
    }
}