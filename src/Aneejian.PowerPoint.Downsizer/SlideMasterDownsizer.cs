using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer
{
    public class SlideMasterDownsizer
    {
        private int _deletedLayouts;
        private int _deletedMasters;
        private bool _isSuccess = true;
        private Exception _exception = null;

        public async Task<IResponse> Downsize(Presentation activePresentation)
        {
            try
            {
                var designs = activePresentation.Designs;

                List<CustomLayout> usedCustomLayouts = await Task.FromResult((from Slide slide in activePresentation.Slides
                                                                              select slide.CustomLayout).ToList()).ConfigureAwait(false);

                List<Master> availableMasters = new List<Master>();
                List<CustomLayout> availableCustomLayouts = new List<CustomLayout>();

                foreach (Design design in designs)
                {
                    var slideMaster = design.SlideMaster;
                    availableMasters.Add(slideMaster);

                    List<CustomLayout> designCustomLayouts = await Task.FromResult((from CustomLayout layout in slideMaster.CustomLayouts
                                                                                    select layout).ToList()).ConfigureAwait(false);

                    availableCustomLayouts.AddRange(designCustomLayouts);
                }

                foreach (CustomLayout layout in availableCustomLayouts.Where(layout => !usedCustomLayouts.Contains(layout)))
                {
                    layout.Delete();
                    _deletedLayouts++;
                }

                foreach (Master master in availableMasters.Where(master => master.CustomLayouts.Count == 0))
                {
                    master.Delete();
                    _deletedMasters++;
                }
            }
            catch (Exception e)
            {
                _isSuccess = false;
                _exception = e;
            }

            return await Task.FromResult(new SlideMasterDownsizeResponse(_isSuccess, _deletedMasters, _deletedLayouts, _exception)).ConfigureAwait(false);
        }
    }
}