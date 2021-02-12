using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer
{
    public class SlideMasterDownsizePotential : ISlideMasterDownsizePotential
    {
        public List<CustomLayout> UnusedLayouts { get; set; } = new List<CustomLayout>();
        public List<Master> UnusedMasters { get; set; } = new List<Master>();
        public int UnusedLayoutsCount => UnusedLayouts.Count;
        public int UnusedMastersCount => UnusedMasters.Count;

        public SlideMasterDownsizePotential(List<CustomLayout> unusedLayouts, List<Master> unusedMasters)
        {
            UnusedLayouts = unusedLayouts;
            UnusedMasters = unusedMasters;
        }
    }
}