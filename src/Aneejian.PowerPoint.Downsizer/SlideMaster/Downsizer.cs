﻿using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.SlideMaster
{
    public class Downsizer
    {
        public delegate void StatsUpdater(IDownsizeResponse downsizeResponse = null);

        public async Task<IDownsizeResponse> Downsize(IDownsizePotential potential, IDownsizeResponse downsizeResponse, StatsUpdater updateStat = null)
        {
            try
            {
                foreach (CustomLayout layout in potential.UnusedLayouts)
                {
                    layout.Delete();
                    downsizeResponse.CustomLayoutsDeleted++;
                }

                foreach (Master master in potential.UnusedMasters)
                {
                    master.Delete();
                    downsizeResponse.MasterSlidesDeleted++;
                }

                downsizeResponse.IsSuccess = true;
                downsizeResponse.ResultMessage = Constants.Messages.SlideMasterDonwsizeSuccess;
            }
            catch (Exception e)
            {
                downsizeResponse.Exception = e;
                downsizeResponse.ResultMessage = Constants.Messages.SlideMasterDonwsizeFailed;
            }

            updateStat?.Invoke(downsizeResponse);

            return await Task.FromResult(downsizeResponse).ConfigureAwait(false);
        }

        public async Task<IDownsizePotential> GetDownsizePotential(Presentation activePresentation, IDownsizePotential potential, StatsUpdater updateStat = null)
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
            potential.UnusedLayouts = availableCustomLayouts.Where(layout => !usedCustomLayouts.Contains(layout)).ToList();
            potential.UnusedMasters = availableMasters.Where(master => !(from CustomLayout layout in master.CustomLayouts select layout).ToList().Except(potential.UnusedLayouts).Any()).ToList();

            updateStat?.Invoke();

            return await Task.FromResult(potential).ConfigureAwait(false);
        }
    }
}