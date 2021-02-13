using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class PerformAction
    {
        internal static async Task DownSize()
        {
            await new SlideMasterDownsizer().Downsize(Globals.DownsizerAddIn.Application.ActivePresentation, Reporter.ReportDownsizeStatus).ConfigureAwait(false);
        }

        internal static async Task Help()
        {
            await Task.FromResult(Process.Start(Fickles.HelpUrl)).ConfigureAwait(false);
        }

        internal static async Task Coffee()
        {
            await Task.FromResult(Process.Start(Fickles.BuyCoffeeUrl)).ConfigureAwait(false);
        }

        internal static async Task GetPotential()
        {
            await new SlideMasterDownsizer().DownsizePotential(Globals.DownsizerAddIn.Application.ActivePresentation, Reporter.ReportDownsizePotential).ConfigureAwait(false);
        }

        internal static string GetProperty(string tag, ControlProperties property)
        {
            return RibbonControlValues.GetControlProperty(tag, property);
        }
    }
}