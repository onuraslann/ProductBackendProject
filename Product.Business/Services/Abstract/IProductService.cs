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
    public  interface IProductService
    {
        Task<IDataResult<ProductListDto>> GetList();
        Task<IDataResult<ProductListDto>> GetByCategory(int categoryId);
        Task<IResult> Add(ProductAddDto productAddDto, string createdByName);
        Task<IResult> Update(ProductUpdateDto  productUpdateDto, string modifiedByName);
        Task<IDataResult<ProductListDto>> GetByBrand(int brandId);
        Task<IResult> HardDelete(int productId);
        IDataResult<List<ProductDetailDto>> GetByDtoAsync();
    }
}

