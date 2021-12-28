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
    public class BrandManager : IBrandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public BrandManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Add(BrandAddDto brandAddDto, string createdByName)
        {
            var brand = _mapper.Map<Brand>(brandAddDto);
          
            brand.CreatedByName = createdByName;
            brand.ModifiedByName = createdByName;
            await _unitOfWork.Brand.AddAsync(brand).ContinueWith(t => _unitOfWork.SaveAsync());
            return new SuccessResult(Messages.BrandAdded);
        }

     

        public async Task<IDataResult<BrandListDto>> GetList()
        {
            var brand = await _unitOfWork.Brand.GetAllAsync();
            if (brand.Count>-1)
            {
                return new SuccessDataResult<BrandListDto>(new BrandListDto{
                 Brands=brand
                },Messages.BrandList);

            }
            return new ErrorDataResult<BrandListDto>(Messages.ErrorMessages);
            
        }

        public async  Task<IResult> HardDelete(int brandId)
        {
            var brand = await _unitOfWork.Brand.GetAsync(b => b.Id == brandId);
            if (brand != null)
            {
             
                await _unitOfWork.Brand.DeleteAsync(brand).ContinueWith(t => _unitOfWork.SaveAsync());
                return new SuccessResult();
            }
            return new ErrorResult(Messages.ErrorMessages);
        }

        public async Task<IResult> Update(BrandUpdateDto brandUpdateDto, string modifiedByName)
        {
            var brand  = _mapper.Map<Brand>(brandUpdateDto);
            brand.ModifedDate = DateTime.Now;
            brand.ModifiedByName = modifiedByName;
            await _unitOfWork.Brand.UpdateAsync(brand).ContinueWith(t => _unitOfWork.SaveAsync());
            return new SuccessResult(Messages.BrandUpdate);
        }
    }
}
