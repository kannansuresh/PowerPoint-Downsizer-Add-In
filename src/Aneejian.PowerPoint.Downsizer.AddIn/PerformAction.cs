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

        internal static async Task Donate()
        {
            await Task.FromResult(Process.Start(Fickles.BuyCoffeeUrl)).ConfigureAwait(false);
        }

        internal static async Task GetPotential()
        {
            await new SlideMasterDownsizer().DownsizePotential(Globals.DownsizerAddIn.Application.ActivePresentation, Reporter.ReportDownsizePotential).ConfigureAwait(false);
        }

        internal static void UnhideOrHideTab()
        {
            var downsizerTab = Globals.Ribbons.DownsizerRibbon.TabDownsizer;
            var visible = downsizerTab.Visible;

            downsizerTab.Visible = !visible;

            var buttonLabel = visible ? "Unhide Tab" : "Hide Tab";
            var buttonTip = visible ? Fickles.UnhideTabLabel : Fickles.HideTabLabel;
            var officeImageId = visible ? "WindowUnhide" : "WindowHide";

            var buttonInTab = Globals.Ribbons.DownsizerRibbon.BtnHideDownsizerTab;
            var buttonInView = Globals.Ribbons.DownsizerRibbon.BtnHideTabInView;

            var buttons = new List<RibbonButton>() { buttonInTab, buttonInView };

            foreach (var button in buttons)
            {
                button.Label = buttonLabel;
                button.OfficeImageId = officeImageId;
                button.ScreenTip = buttonLabel;
                button.SuperTip = buttonTip;
                button.Description = buttonTip;
            }
        }
    }
}