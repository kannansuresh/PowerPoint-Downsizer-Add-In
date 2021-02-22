using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal class UsageStats : IUsageStats
    {
        private readonly string nl = Environment.NewLine;
        public ulong UsageCounter => Properties.Settings.Default.Stat_UsageCounter;

        public ulong LayoutsRemoved => Properties.Settings.Default.Stat_LayoutsDeleted;

        public ulong MastersRemoved => Properties.Settings.Default.Stat_MastersDeleted;

        public override string ToString()
        {
            return $"You have used the add-in {UsageCounter} times. {nl}" +
                $"Layouts removed: {LayoutsRemoved}. {nl}" +
                $"Master Slides removed: {MastersRemoved}. {nl}";
        }
    }
}