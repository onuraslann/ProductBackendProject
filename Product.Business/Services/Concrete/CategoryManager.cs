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
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {   
            await _unitOfWork.Categories.AddAsync(new Category
            {
                CategoryName = categoryAddDto.CategoryName,
                Description = categoryAddDto.Description,
                IsActive = categoryAddDto.IsActive,
                 CreatedByName=createdByName,
                 CreatedDate=DateTime.Now,
                  ModifiedByName=createdByName,
                  ModifedDate=DateTime.Now,
                  IsDeleted=false
            }).ContinueWith(t=>_unitOfWork.SaveAsync());
          
            return new SuccessResult(Messages.CategoryAdded);
        }

        public async Task<IResult> Delete(int categoryId, string modifiedByName)
        {
            var category =  await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            if (category != null)
            {
                category.IsDeleted = true;
                category.ModifiedByName = modifiedByName;
                category.ModifedDate = DateTime.Now;
                await _unitOfWork.Categories.DeleteAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
                return new SuccessResult();
            }
            return new ErrorResult(Messages.ErrorMessages);
           
        }

        public async Task<IDataResult<IList<Category>>> GetList()
        {
            var category = await _unitOfWork.Categories.GetAllAsync();
            if (category.Count>-1)
            {
                return new SuccessDataResult<IList<Category>>(category, Messages.CategoryList);
            }
            return new ErrorDataResult<IList<Category>>(Messages.ErrorMessages);
        }

        public async Task<IResult> HardDelete(int categoryId)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            if (category != null)
            {
                await _unitOfWork.Categories.DeleteAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
              
                return new SuccessResult();
            }
            return new ErrorResult(Messages.ErrorMessages);
        }

        public async Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryUpdateDto.Id);

            if (category != null)
            {
                category.CategoryName = categoryUpdateDto.CategoryName;
                category.Description = categoryUpdateDto.Description;
                category.IsActive = categoryUpdateDto.IsActive;
                category.IsDeleted = categoryUpdateDto.IsDeleted;
                category.ModifiedByName = modifiedByName;
                category.ModifedDate = DateTime.Now;
                await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t=>_unitOfWork.SaveAsync());
                return new SuccessResult(Messages.UpdatedCategory);

               

            }
            return new ErrorResult(Messages.ErrorMessages);

       
        }
    }
}
