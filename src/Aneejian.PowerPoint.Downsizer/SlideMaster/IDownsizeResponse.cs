namespace Aneejian.PowerPoint.Downsizer.SlideMaster
{
    public interface IDownsizeResponse : IResponse
    {
        int CustomLayoutsDeleted { get; set; }
        int MasterSlidesDeleted { get; set; }
        string DownsizeResult { get; }
    }
}