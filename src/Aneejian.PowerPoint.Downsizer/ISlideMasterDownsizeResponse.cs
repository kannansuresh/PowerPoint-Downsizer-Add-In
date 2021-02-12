namespace Aneejian.PowerPoint.Downsizer
{
    public interface ISlideMasterDownsizeResponse : IResponse
    {
        int CustomLayoutsDeleted { get; set; }
        int MasterSlidesDeleted { get; set; }
    }
}