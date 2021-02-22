using Aneejian.PowerPoint.Downsizer.SlideMaster;
using System;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class StatsManager
    {
        private static readonly Properties.Settings _settings = Properties.Settings.Default;

        internal static void UpdateStats(IDownsizeResponse downsizeResponse = null)
        {
            try
            {
                _settings.Stat_UsageCounter++;

                if (downsizeResponse != null)
                {
                    _settings.Stat_LayoutsDeleted += Convert.ToUInt64(downsizeResponse.CustomLayoutsDeleted);
                    _settings.Stat_MastersDeleted += Convert.ToUInt64(downsizeResponse.MasterSlidesDeleted);
                }

                if (!_settings.Coffee_AlreadyBought && _settings.Coffee_HiddenSinceCounter >= _settings.Coffee_ButtonRevealThreshold * _settings.Coffee_HideCounter)
                {
                    _settings.Ribbon_ShowCoffeeButton = true;
                    _settings.Coffee_HiddenSinceCounter = 0;
                }

                _settings.Save();
            }
            catch (Exception)
            {
                _settings.Reset();
            }
        }
    }
}