using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool success,string message):this(success)
        {
            Messages = message;

        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Messages { get; }
    }
}
