using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Utilities.Result
{
    public interface IResult
    {
        bool Success { get; }
        string Messages { get; }
    }
}
