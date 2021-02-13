using System;

namespace Aneejian.PowerPoint.Downsizer
{
    public interface IResponse
    {
        bool IsSuccess { get; set; }
        string ResultMessage { get; set; }
        Exception Exception { get; set; }
    }
}