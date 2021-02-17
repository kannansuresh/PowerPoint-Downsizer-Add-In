using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class Reporter
    {
        private const string caption = Fickles.AddInName;
        private static readonly string nl = Environment.NewLine;
        private static readonly Properties.Settings settings = Properties.Settings.Default;

        internal static async Task ReportDownsizeStatus(ISlideMasterDownsizeResponse response)
        {
            var removedAny = response.CustomLayoutsDeleted > 0 || response.MasterSlidesDeleted > 0;
            var msgBoxIcon = MessageBoxIcon.Exclamation;

            if (response.IsSuccess && removedAny)
            {
                msgBoxIcon = MessageBoxIcon.Information;
            }
            else if (!response.IsSuccess)
            {
                msgBoxIcon = MessageBoxIcon.Error;
            }

            await Task.FromResult(MessageBox.Show(response.ResultMessage, caption, MessageBoxButtons.OK, msgBoxIcon)).ConfigureAwait(false);
        }

        internal static async Task ReportDownsizePotential(ISlideMasterDownsizePotential potential, bool performDownsize = true)
        {
            var anyPotential = potential.UnusedLayoutsCount > 0 || potential.UnusedMastersCount > 0;
            var msgBoxIcon = anyPotential ? MessageBoxIcon.Information : MessageBoxIcon.Exclamation;
            var message = anyPotential ? $"Unused layouts: {potential.UnusedLayoutsCount}{nl}Unused master slides: {potential.UnusedMastersCount}." : Fickles.NothingToRemove;

            //message += $"{nl}Usage counter: {settings.UsageCounter}{nl}Hidden counter: {settings.CoffeeHiddenSinceCounter}";

            if (anyPotential)
            {
                if (performDownsize)
                {
                    message += $"{nl}{nl}Do you want to remove them now?";
                    var downsize = await Task.FromResult(MessageBox.Show(message, caption, MessageBoxButtons.YesNo, msgBoxIcon, MessageBoxDefaultButton.Button2)).ConfigureAwait(false);
                    if (downsize == DialogResult.Yes)
                    {
                        _ = PerformAction.DownSize();
                    }
                }
                else
                {
                    await Task.FromResult(MessageBox.Show(message, caption, MessageBoxButtons.OK, msgBoxIcon)).ConfigureAwait(false);
                }
            }
            else
            {
                await Task.FromResult(MessageBox.Show(message, caption, MessageBoxButtons.OK, msgBoxIcon)).ConfigureAwait(false);
            }
        }

        internal static async Task ReportHideCoffee()
        {
            var message = $"Already bought a coffee? {nl}{nl}";

            message += string.Format("You have used this add-in {2} times.{0}Consider buying a coffee if you liked it.{0}{0}Click 'Yes' if you have already bought a coffee? {0}{0}If you haven't bought a coffee yet, the 'Buy a Coffee!' button will reveal itself after you have used this add-in {1} more times after clicking 'No'.", nl, settings.RevealCoffeButtonThreshold * (settings.CoffeeHideCounter + 1), settings.UsageCounter);

            var hide = await Task.FromResult(MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)).ConfigureAwait(false);

            switch (hide)
            {
                case DialogResult.Yes:
                    settings.AlreadyDonated = true;
                    settings.ShowCoffeeButton = false;
                    settings.Save();
                    break;

                case DialogResult.No:
                    settings.ShowCoffeeButton = false;
                    settings.CoffeeHiddenSinceCounter = 0;
                    settings.CoffeeHideCounter++;
                    settings.Save();
                    break;
            }
        }
    }
}