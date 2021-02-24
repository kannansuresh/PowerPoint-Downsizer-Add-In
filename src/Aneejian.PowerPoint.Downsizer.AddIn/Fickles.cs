namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal static class Fickles
    {
        // URLs

        internal const string CompanyUrl = "https://aneejian.com";
        internal const string RepositoryUrl = "https://kannansuresh.github.io/PowerPoint-Downsizer-Add-In/";
        internal const string BlogPostUrl = "https://aneejian.com/powerpoint-downsizer-add-in/";
        internal const string CheckUpdateUrl = "https://kannansuresh.github.io/PowerPoint-Downsizer-Add-In/update-info.txt";
        internal const string HelpUrl = BlogPostUrl;

        // Coffee

        internal const string CoffeeUrl = "https://www.buymeacoffee.com/aneejian";
        internal const int CoffeeRevealThreshold = 10;
        internal const bool EnableCoffee = true;

        internal static class AppInfo
        {
            // Assembly info

            internal const string Title = "PowerPoint Downsizer Add-In";
            internal const string Description = "Add-In to downsize PowerPoint presentations by removing unused layouts and master slides.";
            internal const string Company = "Aneejian";
            internal const string Product = Title;
            internal const string Copyright = "Copyright ©  Aneejian 2021";
            internal const string Version = "v1.0.0";
        }

        internal static class Messages
        {
            public const string NothingToRemove = "Nothing to remove. All layouts and master slides in use.";

            public const string SlideMasterDonwsizeSuccess = "Successfully removed unused custom layouts and master slides.";

            public const string SlideMasterDonwsizeFailed = "Failed to remove unused custom layouts and master slides.";
        }
    }
}