﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Utilities.Result
{
  public  interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
