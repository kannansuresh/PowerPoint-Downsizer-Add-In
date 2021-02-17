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

        public delegate Task ReportDownsizingStatus(ISlideMasterDownsizeResponse response);

        public delegate Task ReportDownsizingPotential(ISlideMasterDownsizePotential potential, bool performDownsize);

        public async Task<IResponse> Downsize(Presentation activePresentation, ReportDownsizingStatus response = null)
        {
            try
            {
                var potential = await DownsizePotential(activePresentation).ConfigureAwait(false);

                foreach (CustomLayout layout in potential.UnusedLayouts)
                {
                    layout.Delete();
                    _deletedLayouts++;
                }

                foreach (Master master in potential.UnusedMasters)
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

            var downsizeResponse = await Task.FromResult(new SlideMasterDownsizeResponse(_isSuccess, _deletedMasters, _deletedLayouts, _exception)).ConfigureAwait(false);

            if (response != null)
            {
                await response(downsizeResponse).ConfigureAwait(false);
            }

            return downsizeResponse;
        }

        public async Task<ISlideMasterDownsizePotential> DownsizePotential(Presentation activePresentation, ReportDownsizingPotential potential = null, bool performDownsize = true)
        {
            var designs = activePresentation.Designs;
            List<Master> availableMasters = new List<Master>();
            List<CustomLayout> availableCustomLayouts = new List<CustomLayout>();

            List<CustomLayout> usedCustomLayouts = await Task.FromResult((from Slide slide in activePresentation.Slides
                                                                          select slide.CustomLayout).ToList()).ConfigureAwait(false);

            foreach (Design design in designs)
            {
                var slideMaster = design.SlideMaster;
                availableMasters.Add(slideMaster);
                List<CustomLayout> designCustomLayouts = await Task.FromResult((from CustomLayout layout in slideMaster.CustomLayouts
                                                                                select layout).ToList()).ConfigureAwait(false);
                availableCustomLayouts.AddRange(designCustomLayouts);
            }
            var deletableLayouts = availableCustomLayouts.Where(layout => !usedCustomLayouts.Contains(layout)).ToList();
            var deletableMasters = availableMasters.Where(master => !(from CustomLayout layout in master.CustomLayouts select layout).ToList().Except(deletableLayouts).Any()).ToList();

            var downSizePotential = new SlideMasterDownsizePotential(deletableLayouts, deletableMasters);

            if (potential != null)
            {
                await potential(downSizePotential, performDownsize).ConfigureAwait(false);
            }

            return downSizePotential;
        }
    }
}