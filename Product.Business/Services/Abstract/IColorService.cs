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
    public interface IColorService
    {
        Task<IDataResult<ColorListDto>> GetList();
        Task<IResult> Add(ColorAddDto colorAddDto);
        Task<IResult> Update(ColorUpdateDto colorUpdateDto, string modifiedByName);
   
        Task<IResult> HardDelete(int colorId);
    }
}
