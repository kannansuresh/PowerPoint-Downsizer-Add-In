using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal interface IUsageStats
    {
        ulong UsageCounter { get; }

        ulong LayoutsRemoved { get; }

        ulong MastersRemoved { get; }
    }
}