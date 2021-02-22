using Aneejian.PowerPoint.Downsizer.SlideMaster;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class Performer
    {
        private static readonly Properties.Settings _settings = Properties.Settings.Default;

        internal static async Task DownSize(IDownsizePotential potential)
        {
            var downsizeResponse = new DownsizeResponse();
            await new SlideMaster.Downsizer().Downsize(potential, downsizeResponse, StatsManager.UpdateStats).ConfigureAwait(false);
            _ = Reporter.ReportDownsizeStatus(downsizeResponse);
        }

        internal static async Task GetPotentialAndDownsize()
        {
            var potential = new DownsizePotential();
            await new SlideMaster.Downsizer().GetDownsizePotential(Globals.DownsizerAddIn.Application.ActivePresentation, potential).ConfigureAwait(false);
            _ = Reporter.ReportDownsizePotential(potential, true);
        }

        internal static async Task GetPotential()
        {
            var potential = new DownsizePotential();
            await new SlideMaster.Downsizer().GetDownsizePotential(Globals.DownsizerAddIn.Application.ActivePresentation, potential).ConfigureAwait(false);
            _ = Reporter.ReportDownsizePotential(potential, false);
        }

        internal static async Task Help()
        {
            await Task.FromResult(Process.Start(_settings.App_Help)).ConfigureAwait(false);
        }

        internal static async Task Update()
        {
            await Task.FromResult(Process.Start(_settings.Update_FilePath)).ConfigureAwait(false);
        }

        internal static async Task Coffee()
        {
            await Task.FromResult(Process.Start(_settings.Coffee_Url)).ConfigureAwait(false);
        }

        internal static async Task HomePage()
        {
            await Task.FromResult(Process.Start(_settings.App_Homepage)).ConfigureAwait(false);
        }

        internal static object GetProperty(string tag, ControlProperties property)
        {
            return RibbonControlValues.GetControlProperty(tag, property);
        }
    }
}