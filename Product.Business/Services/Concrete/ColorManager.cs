using AutoMapper;
using Product.Business.Constants;
using Product.Business.Services.Abstract;
using Product.Core.Utilities.Busines;
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
        private readonly IMapper _mapper;

     

        public ColorManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Add(ColorAddDto colorAddDto)
        {
            IResult result = BusinesRules.Run(CheckIfColorExist(colorAddDto.ColorName));
            if (result != null)
            {
                return result;
            }

            var color = _mapper.Map<Color>(colorAddDto);
          
            color.CreatedDate = DateTime.Now;
            color.ModifedDate = DateTime.Now;
            await _unitOfWork.Color.AddAsync(color).ContinueWith(t => _unitOfWork.SaveAsync());
            return new SuccessResult(Messages.ColorAdded);
        }

       
        public async Task<IDataResult<ColorListDto>> GetList()
        {
            var color = await _unitOfWork.Color.GetAllAsync();
            if (color.Count > -1)
            {
                return new SuccessDataResult<ColorListDto>(new ColorListDto
                {
                    Colors = color
                }, Messages.ColorList);
            }
            return new ErrorDataResult<ColorListDto>(Messages.ErrorMessages);
        }

        public async Task<IResult> HardDelete(int colorId)
        {
            var color = await _unitOfWork.Color.GetAsync(c => c.Id == colorId);
            if (color != null)
            {
                await _unitOfWork.Color.DeleteAsync(color).ContinueWith(t=>_unitOfWork.SaveAsync());
                return new SuccessResult(Messages.ColorDelete);
            }

            return new ErrorResult(Messages.ErrorMessages);
        }

        public async Task<IResult> Update(ColorUpdateDto colorUpdateDto, string modifiedByName)
        {
            var color = _mapper.Map<Color>(colorUpdateDto);
            color.ModifiedByName = modifiedByName;
            color.CreatedByName = modifiedByName;
            color.CreatedDate = DateTime.Now;
            color.ModifedDate = DateTime.Now;
            await _unitOfWork.Color.UpdateAsync(color).ContinueWith(t=>_unitOfWork.SaveAsync());
            return new SuccessResult();
        }
        private IResult CheckIfColorExist(string colorName)
        {
            var color =  _unitOfWork.Color.GetAll(x => x.ColorName == colorName).Any();
            if (color)
            {
                return new ErrorResult(Messages.ErrorMessages);
            }
            return new SuccessResult();

        }
    }
}
