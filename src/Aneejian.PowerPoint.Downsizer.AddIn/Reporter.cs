using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class Reporter
    {
        private const string caption = Fickles.AddInName;

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

        internal static async Task ReportDownsizePotential(ISlideMasterDownsizePotential potential)
        {
            var anyPotential = potential.UnusedLayoutsCount > 0 || potential.UnusedMastersCount > 0;
            var msgBoxIcon = anyPotential ? MessageBoxIcon.Information : MessageBoxIcon.Exclamation;
            var message = anyPotential ? $"Unused layouts: {potential.UnusedLayoutsCount}{Environment.NewLine}Unused master slides: {potential.UnusedMastersCount}." : Fickles.NothingToRemove;
            await Task.FromResult(MessageBox.Show(message, caption, MessageBoxButtons.OK, msgBoxIcon)).ConfigureAwait(false);
        }
    }
}