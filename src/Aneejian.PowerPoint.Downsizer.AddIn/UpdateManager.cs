using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal class UpdateManager
    {
        internal async Task CheckForUpdates()
        {
            var settings = Properties.Settings.Default;

            try
            {
                var releaseInfo = await GetWebsiteDataAsync(Fickles.CheckUpdateUrl).ConfigureAwait(false);

                if (!string.IsNullOrWhiteSpace(releaseInfo))
                {
                    var updateInfo = releaseInfo.Split(new[] { "\n", "\r", "\n\r" }, StringSplitOptions.RemoveEmptyEntries);
                    var updateAvailable = updateInfo[0].ToNumber() > Fickles.AppInfo.Version.ToNumber();
                    if (updateAvailable) settings.Ribbon_ShowDownsizerTab = true;
                    settings.Ribbon_ShowUpdateButton = updateAvailable;
                    settings.Update_FilePath = updateInfo[1];
                    settings.Save();
                }
            }
            catch (Exception)
            {
                settings.Ribbon_ShowUpdateButton = false;
                settings.Save();
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
                client.DefaultRequestHeaders.Add("User-Agent", Fickles.AppInfo.Product);
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