using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class PerformAction
    {
        internal static async Task DownSize()
        {
            await new SlideMasterDownsizer().Downsize(Globals.DownsizerAddIn.Application.ActivePresentation, Reporter.ReportDownsizeStatus).ConfigureAwait(false);
            IncrementUsageCounter();
        }

        internal static async Task Help()
        {
            await Task.FromResult(Process.Start(Fickles.HelpUrl)).ConfigureAwait(false);
        }

        internal static async Task Coffee()
        {
            await Task.FromResult(Process.Start(Fickles.BuyCoffeeUrl)).ConfigureAwait(false);
        }

        internal static async Task HoemePage()
        {
            await Task.FromResult(Process.Start(Fickles.HomePageUrl)).ConfigureAwait(false);
        }

        internal static async Task GetPotential()
        {
            await new SlideMasterDownsizer().DownsizePotential(Globals.DownsizerAddIn.Application.ActivePresentation, Reporter.ReportDownsizePotential).ConfigureAwait(false);
            IncrementUsageCounter();
        }

        internal static string GetProperty(string tag, ControlProperties property)
        {
            return RibbonControlValues.GetControlProperty(tag, property);
        }

        private static void IncrementUsageCounter()
        {
            try
            {
                Properties.Settings.Default.UsageCounter++;
            }
            catch (Exception)
            {
                Properties.Settings.Default.UsageCounter = 0;
            }

            if (Properties.Settings.Default.UsageCounter >= Properties.Settings.Default.RevealCoffeButtonThreshold)
            {
                Properties.Settings.Default.ShowCoffeeButton = true;
            }

            Properties.Settings.Default.Save();
        }
    }
}