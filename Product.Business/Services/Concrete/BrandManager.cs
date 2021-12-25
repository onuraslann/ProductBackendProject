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

        public BrandManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IResult> Add(BrandAddDto brandAddDto, string createdByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int brandId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IList<Brand>>> GetList()
        {
            var brand =  await _unitOfWork.Brand.GetAllAsync();
            if (brand.Count > -1)
            {
                return new SuccessDataResult<IList<Brand>>(brand, Messages.BrandList);
            }
            return new ErrorDataResult<IList<Brand>>(Messages.ErrorMessages);
        }

        public Task<IResult> HardDelete(int brandId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(BrandUpdateDto brandUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
