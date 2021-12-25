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
    public class ColorManager : IColorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColorManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IResult> Add(ColorAddDto colorAddDto, string createdByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int colorId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IList<Color>>> GetList()
        {
            var color = await _unitOfWork.Color.GetAllAsync();
            if (color.Count>-1)
            {
                return new SuccessDataResult<IList<Color>>(color, Messages.ColorList);
            }
            return new ErrorDataResult<IList<Color>>(Messages.ErrorMessages);
        }

        public Task<IResult> HardDelete(int colorId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(ColorUpdateDto colorUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
