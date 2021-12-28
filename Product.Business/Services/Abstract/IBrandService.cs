using Product.Core.Utilities.Result;
using Product.Entities.Concrete;
using Product.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.Services.Abstract
{
   public interface IBrandService
    {
        Task<IDataResult<BrandListDto>> GetList();
        Task<IResult> Add(BrandAddDto  brandAddDto, string createdByName);
        Task<IResult> Update(BrandUpdateDto brandUpdateDto, string modifiedByName);

        Task<IResult> HardDelete(int brandId);
    }
}
