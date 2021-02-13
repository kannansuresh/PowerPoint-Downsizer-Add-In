using System;

namespace Aneejian.PowerPoint.Downsizer
{
    public abstract class Response : IResponse
    {
        public bool IsSuccess { get; set; }
        public string ResultMessage { get; set; } = "";
        public Exception Exception { get; set; }

        protected Response()
        {
        }

        protected Response(bool isSuccess, string resultMessage, Exception exception)
        {
            IsSuccess = isSuccess;
            ResultMessage = resultMessage;
            Exception = exception;
        }

        protected Response(Exception e, string message)
        {
            IsSuccess = false;
            ResultMessage = message + e.Message;
            Exception = e;
        }
    }
}