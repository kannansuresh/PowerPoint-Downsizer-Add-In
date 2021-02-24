using System;

namespace Aneejian.PowerPoint.Downsizer.SlideMaster
{
    public class DownsizeResponse : Response, IDownsizeResponse
    {
        public int MasterSlidesDeleted { get; set; }
        public int CustomLayoutsDeleted { get; set; }
        private bool RemovedAny => CustomLayoutsDeleted > 0 || CustomLayoutsDeleted > 0;
        public string DownsizeResult => GetDownsizeResult();

        private string GetDownsizeResult()
        {
            var newLine = Environment.NewLine;
            if (IsSuccess)
            {
                return RemovedAny ?
                    $"Unused layouts deleted: {CustomLayoutsDeleted} {newLine}" +
                    $"Unused master slides deleted: {MasterSlidesDeleted}" :
                    Constants.Messages.NothingToRemove;
            }
            else
            {
                return $"Failed to downsize. {Exception.Message}".TrimEnd('.') + ".";
            }
        }
    }
}