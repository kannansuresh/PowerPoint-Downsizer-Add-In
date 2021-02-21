using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal class UpdateChecker
    {
        private static readonly Properties.Settings _settings = Properties.Settings.Default;
        private readonly string _currentVersion = _settings.App_Version;
        private readonly string _upateInfoUrl = _settings.Update_CheckUrl;

        internal async Task CheckForUpdates()
        {
            try
            {
                var releaseInfo = await GetWebsiteDataAsync(_upateInfoUrl).ConfigureAwait(false);

                if (!string.IsNullOrWhiteSpace(releaseInfo))
                {
                    var updateInfo = releaseInfo.Split(new[] { "\n", "\r", "\n\r" }, StringSplitOptions.RemoveEmptyEntries);
                    var updateAvailable = updateInfo[0].ToNumber() > _currentVersion.ToNumber();
                    if (updateAvailable) _settings.Ribbon_ShowDownsizerTab = true;
                    _settings.Ribbon_ShowUpdateButton = updateAvailable;
                    _settings.Update_FilePath = updateInfo[1];
                    _settings.Save();
                }
            }
            catch (Exception)
            {
                _settings.Ribbon_ShowUpdateButton = false;
                _settings.Save();
            }
        }

        private static async Task<string> GetWebsiteDataAsync(string url)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;
            try
            {
                var uri = new Uri(url);
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", "PowerPoint Downsizer Add-In");
                var response = await client.GetAsync(uri).ConfigureAwait(false);
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}