using Product.Business.Constants;
using Product.Business.Services.Abstract;
using Product.Core.Utilities.Result;
using Product.DataAccess.Abstract;
using Product.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.Services.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IResult> Add(ProductAddDto productAddDto, string createdByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int productId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ProductListDto>> GetByCategory(int categoryId)
        {
           
            var product = await _unitOfWork.Product.GetAllAsync(p => p.CategoryId == categoryId);
            if (product.Count>-1)
            {
                return new SuccessDataResult<ProductListDto>(new ProductListDto
                {
                    Productts = product
                });
            }
            return new ErrorDataResult<ProductListDto>(Messages.ErrorMessages);
        }

        public async Task<IDataResult<ProductListDto>> GetList()
        {
            var product = await _unitOfWork.Product.GetAllAsync();
            if (product.Count > -1)
            {
                return new SuccessDataResult<ProductListDto>(new ProductListDto
                {
                    Productts = product
                },Messages.ProductList);
            }
            return new ErrorDataResult<ProductListDto>(Messages.ErrorMessages);
        }

        public Task<IResult> HardDelete(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(ProductUpdateDto productUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
