using Product.Core.Utilities.Result;
using Product.Entities.Concrete;
using Product.Entities.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryListDto>> GetList();

        Task<IResult> Add(CategoryAddDto categoryAddDto);
   
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto,string modifiedByName);

        Task<IResult> HardDelete(int categoryId);
        IDataResult<List<Category>> GetAll();

       
    }
}
