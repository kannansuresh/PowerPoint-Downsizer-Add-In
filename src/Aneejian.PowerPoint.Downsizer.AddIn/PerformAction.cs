using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class PerformAction
    {
        private static readonly Properties.Settings _settings = Properties.Settings.Default;

        internal static async Task DownSize()
        {
            IncrementUsageCounter();
            await new SlideMasterDownsizer().Downsize(Globals.DownsizerAddIn.Application.ActivePresentation, Reporter.ReportDownsizeStatus).ConfigureAwait(false);
        }

        internal static async Task GetPotentialAndDownsize()
        {
            IncrementUsageCounter();
            await new SlideMasterDownsizer().DownsizePotential(Globals.DownsizerAddIn.Application.ActivePresentation, Reporter.ReportDownsizePotential).ConfigureAwait(false);
        }

        internal static async Task GetPotential()
        {
            IncrementUsageCounter();
            await new SlideMasterDownsizer().DownsizePotential(Globals.DownsizerAddIn.Application.ActivePresentation, Reporter.ReportDownsizePotential, false).ConfigureAwait(false);
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
            return new RibbonControlValues().GetControlProperty(tag, property);
        }

        private static void IncrementUsageCounter()
        {
            try
            {
                _settings.App_UsageCounter++;

                if (!_settings.Coffee_AlreadyBought && _settings.Coffee_HiddenSinceCounter >= _settings.Coffee_ButtonRevealThreshold * _settings.Coffee_HideCounter)
                {
                    _settings.Ribbon_ShowCoffeeButton = true;
                    _settings.Coffee_HiddenSinceCounter = 0;
                }

                _settings.Save();
            }
            catch (Exception)
            {
                _settings.Reset();
            }
        }
    }
}