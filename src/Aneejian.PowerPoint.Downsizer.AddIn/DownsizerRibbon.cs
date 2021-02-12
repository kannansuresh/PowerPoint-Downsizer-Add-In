using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    public partial class DownsizerRibbon
    {
        private void DownsizerRibbon_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private async void BtnDownsizeSlideMaster_Click(object sender, RibbonControlEventArgs e)
        {
            await new SlideMasterDownsizer().Downsize(Globals.DownsizerAddIn.Application.ActivePresentation, Reporter.ReportStatus).ConfigureAwait(false);
        }

        private void BtnHelp_Click(object sender, RibbonControlEventArgs e)
        {
            Process.Start(Fickles.HelpUrl);
        }

        private void BtnDonate_Click(object sender, RibbonControlEventArgs e)
        {
            Process.Start(Fickles.BuyCoffeeUrl);
        }
    }
}