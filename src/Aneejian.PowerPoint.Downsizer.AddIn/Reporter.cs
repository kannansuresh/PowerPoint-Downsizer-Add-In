using Aneejian.PowerPoint.Downsizer.SlideMaster;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class Reporter
    {
        private const string caption = Fickles.AppInfo.Product;
        private static readonly string nl = Environment.NewLine;

        internal static async Task ReportDownsizeStatus(IDownsizeResponse response)
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

            await Task.FromResult(MessageBox.Show(response.DownsizeResult, caption, MessageBoxButtons.OK, msgBoxIcon)).ConfigureAwait(false);
        }

        internal static async Task ReportError(string message)
        {
            await Task.FromResult(MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error)).ConfigureAwait(false);
        }

        internal static async Task ReportDownsizePotential(IDownsizePotential potential, bool performDownsize)
        {
            var anyPotential = potential.UnusedLayoutsCount > 0 || potential.UnusedMastersCount > 0;
            var msgBoxIcon = anyPotential ? MessageBoxIcon.Information : MessageBoxIcon.Exclamation;
            var message = anyPotential ? $"Unused layouts: {potential.UnusedLayoutsCount}{nl}Unused master slides: {potential.UnusedMastersCount}" : Fickles.Messages.NothingToRemove;

            if (anyPotential)
            {
                if (performDownsize)
                {
                    msgBoxIcon = MessageBoxIcon.Question;
                    message += $"{nl}{nl}Do you want to remove them now?";
                    var downsize = await Task.FromResult(MessageBox.Show(message, caption, MessageBoxButtons.YesNo, msgBoxIcon, MessageBoxDefaultButton.Button2)).ConfigureAwait(false);
                    if (downsize == DialogResult.Yes)
                    {
                        _ = Performer.DownSize(potential);
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

        internal static async Task ReportUsageStats()
        {
            var stats = await Task.FromResult(new UsageStats().ToString()).ConfigureAwait(false);
            MessageBox.Show(new Form() { TopMost = true }, stats, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static async Task ReportHideCoffee()
        {
            var settings = Properties.Settings.Default;
            var message = $"Already bought a coffee? {nl}{nl}";

            message += string.Format("You have used this add-in {2} times.{0}Consider buying a coffee if you liked it.{0}{0}Click 'Yes' if you have already bought a coffee? {0}{0}If you haven't bought a coffee yet, the 'Buy a Coffee!' button will reveal itself after you have used this add-in {1} more times after clicking 'No'.", nl, Fickles.CoffeeRevealThreshold * (settings.Coffee_HideCounter + 1), settings.Stat_UsageCounter);

            var hide = await Task.FromResult(MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)).ConfigureAwait(false);

            switch (hide)
            {
                case DialogResult.Yes:
                    settings.Coffee_AlreadyBought = true;
                    settings.Ribbon_ShowCoffeeButton = false;
                    settings.Save();
                    break;

                case DialogResult.No:
                    settings.Ribbon_ShowCoffeeButton = false;
                    settings.Coffee_HiddenSinceCounter = 0;
                    settings.Coffee_HideCounter++;
                    settings.Save();
                    break;
            }
        }
    }
}