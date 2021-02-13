using Microsoft.Office.Interop.PowerPoint;
using System.Collections.Generic;

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