using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aneejian.PowerPoint.Downsizer
{
    public interface IResponse
    {
        bool IsSuccess { get; set; }
        string ResultMessage { get; set; }
        Exception Exception { get; set; }
    }
}