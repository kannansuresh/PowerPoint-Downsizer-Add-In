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
        internal static async Task ReportStatus(IResponse response)
        {
            await Task.FromResult(MessageBox.Show(response.ResultMessage)).ConfigureAwait(false);
        }
    }
}