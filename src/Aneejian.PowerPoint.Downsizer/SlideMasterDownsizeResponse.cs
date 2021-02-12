using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer
{
    public class SlideMasterDownsizeResponse : Response, ISlideMasterDownsizeResponse
    {
        private bool RemovedAny => CustomLayoutsDeleted > 0 || CustomLayoutsDeleted > 0;
        public int MasterSlidesDeleted { get; set; }
        public int CustomLayoutsDeleted { get; set; }

        public SlideMasterDownsizeResponse(bool isSuccess, int masterSlidesDeleted, int customLayoutsDeleted, Exception exception = null)
        {
            IsSuccess = isSuccess;
            MasterSlidesDeleted = masterSlidesDeleted;
            CustomLayoutsDeleted = customLayoutsDeleted;
            Exception = exception;
            ResultMessage = GetResultMessage();
        }

        private string GetResultMessage()
        {
            var newLine = Environment.NewLine;
            if (IsSuccess)
            {
                return RemovedAny ?
                    $"Unused layouts deleted: {CustomLayoutsDeleted} {newLine}Unused master slides deleted: {MasterSlidesDeleted}." :
                    Fickles.NothingToRemove;
            }
            else
            {
                return $"Failed to downsize. {Exception.Message}".TrimEnd('.') + ".";
            }
        }
    }
}