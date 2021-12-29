using AutoMapper;
using Product.Business.Constants;
using Product.Business.Services.Abstract;
using Product.Core.Utilities.Result;
using Product.DataAccess.Abstract;
using Product.Entities.Concrete;
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
        private readonly IMapper _mapper;

       
        public ProductManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper; 
        }

        public async Task<IResult> Add(ProductAddDto productAddDto, string createdByName)
        {
            var product = _mapper.Map<Productt>(productAddDto);
            product.CreatedDate = DateTime.Now;
            product.ModifedDate = DateTime.Now;
            product.IsDeleted = false;
          
            product.CreatedByName = createdByName;
            product.ModifiedByName = createdByName;
            await _unitOfWork.Product.AddAsync(product).ContinueWith(t=>_unitOfWork.SaveAsync());
            return new SuccessResult();
        }

        public async Task<IDataResult<ProductListDto>> GetByBrand(int brandId)
        {
            var product = await _unitOfWork.Product.GetAllAsync(p => p.BrandId == brandId);
            if (product != null)
            {
                return new SuccessDataResult<ProductListDto>(new ProductListDto
                {
                    Productts = product
                }) ;
            }
            return new ErrorDataResult<ProductListDto>(Messages.ErrorMessages);
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

        public IDataResult<List<ProductDetailDto>> GetByDtoAsync()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_unitOfWork.Product.GetByDto());
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

        public async Task<IResult> HardDelete(int productId)
        {
            var product = await _unitOfWork.Product.GetAsync(p => p.Id == productId);
            if (product != null)
            {
                await _unitOfWork.Product.DeleteAsync(product).ContinueWith(t => _unitOfWork.SaveAsync());
                return new SuccessResult();
            }
            return new ErrorResult(Messages.ErrorMessages);

        }

        public async Task<IResult> Update(ProductUpdateDto productUpdateDto, string modifiedByName)
        {

            var product = _mapper.Map<Productt>(productUpdateDto);
            product.ModifiedByName = modifiedByName;
            await _unitOfWork.Product.UpdateAsync(product).ContinueWith(p => _unitOfWork.SaveAsync());
            return new SuccessResult();
        }
        
    }
}
