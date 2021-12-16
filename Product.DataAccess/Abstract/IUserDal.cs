﻿using Product.Core.DataAccess.Abstract;
using Product.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
    }
}
