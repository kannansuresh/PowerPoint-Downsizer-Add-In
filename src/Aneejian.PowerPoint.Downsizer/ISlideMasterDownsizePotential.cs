using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer
{
    public interface ISlideMasterDownsizePotential
    {
        int UnusedLayoutsCount { get; }
        int UnusedMastersCount { get; }
        List<CustomLayout> UnusedLayouts { get; set; }
        List<Master> UnusedMasters { get; set; }
    }
}