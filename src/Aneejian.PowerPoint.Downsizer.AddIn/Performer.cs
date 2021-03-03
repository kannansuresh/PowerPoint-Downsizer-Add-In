using Aneejian.PowerPoint.Downsizer.SlideMaster;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class Performer
    {
        private static readonly Properties.Settings _settings = Properties.Settings.Default;
        private static readonly string nl = Environment.NewLine;

        internal static async Task DownSize(IDownsizePotential potential)
        {
            try
            {
                var downsizeResponse = new DownsizeResponse();
                await new SlideMaster.Downsizer().Downsize(potential, downsizeResponse, StatsManager.UpdateStats).ConfigureAwait(false);
                _ = Reporter.ReportDownsizeStatus(downsizeResponse);
            }
            catch (System.Exception e)
            {
                _ = Reporter.ReportError($"Failed to downsize the presentation. {nl}{e.Message}");
            }
        }

        internal static async Task GetPotentialAndDownsize()
        {
            await GetPotential(true).ConfigureAwait(false);
        }

        internal static async Task GetPotential(bool performDownsize)
        {
            try
            {
                var potential = new DownsizePotential();
                await new SlideMaster.Downsizer().GetDownsizePotential(Globals.DownsizerAddIn.Application.ActivePresentation, potential).ConfigureAwait(false);
                _ = Reporter.ReportDownsizePotential(potential, performDownsize);
            }
            catch (System.Exception e)
            {
                _ = Reporter.ReportError($"Failed to downsize the presentation. Check if the presentation is in protected mode. {nl}{e.Message}");
            }
        }

        internal static async Task Help()
        {
            await Task.FromResult(Process.Start(Fickles.HelpUrl)).ConfigureAwait(false);
        }

        internal static async Task Update()
        {
            await Task.FromResult(Process.Start(_settings.Update_FilePath)).ConfigureAwait(false);
        }

        internal static async Task Coffee()
        {
            await Task.FromResult(Process.Start(Fickles.CoffeeUrl)).ConfigureAwait(false);
        }

        internal static async Task HomePage()
        {
            await Task.FromResult(Process.Start(Fickles.CompanyUrl)).ConfigureAwait(false);
        }

        internal static object GetProperty(string tag, ControlProperties property)
        {
            return RibbonControlValues.GetControlProperty(tag, property);
        }
    }
}