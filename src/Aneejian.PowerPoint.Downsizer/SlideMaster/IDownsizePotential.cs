using Microsoft.Office.Interop.PowerPoint;
using System.Collections.Generic;

namespace Aneejian.PowerPoint.Downsizer.SlideMaster
{
    public interface IDownsizePotential
    {
        int UnusedLayoutsCount { get; }
        int UnusedMastersCount { get; }
        List<CustomLayout> UnusedLayouts { get; set; }
        List<Master> UnusedMasters { get; set; }
    }
}