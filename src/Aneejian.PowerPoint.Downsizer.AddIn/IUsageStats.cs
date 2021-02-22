namespace Aneejian.PowerPoint.Downsizer.AddIn
{
    internal interface IUsageStats
    {
        ulong UsageCounter { get; }

        ulong LayoutsRemoved { get; }

        ulong MastersRemoved { get; }
    }
}