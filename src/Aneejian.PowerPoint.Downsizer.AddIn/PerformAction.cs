using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class PerformAction
    {
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
            await Task.FromResult(Process.Start(Fickles.HelpUrl)).ConfigureAwait(false);
        }

        internal static async Task Coffee()
        {
            await Task.FromResult(Process.Start(Fickles.BuyCoffeeUrl)).ConfigureAwait(false);
        }

        internal static async Task HomePage()
        {
            await Task.FromResult(Process.Start(Fickles.HomePageUrl)).ConfigureAwait(false);
        }

        internal static object GetProperty(string tag, ControlProperties property)
        {
            return new RibbonControlValues().GetControlProperty(tag, property);
        }

        private static void IncrementUsageCounter()
        {
            var settings = Properties.Settings.Default;
            try
            {
                settings.UsageCounter++;

                if (!settings.AlreadyDonated && settings.CoffeeHiddenSinceCounter >= settings.RevealCoffeButtonThreshold * settings.CoffeeHideCounter)
                {
                    settings.ShowCoffeeButton = true;
                    settings.CoffeeHiddenSinceCounter = 0;
                }

                settings.Save();
            }
            catch (Exception)
            {
                settings.Reset();
            }
        }
    }
}