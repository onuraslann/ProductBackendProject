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
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

  

        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            var categories = _mapper.Map<Category>(categoryAddDto);
            categories.CreatedByName = createdByName;
            categories.ModifedDate = DateTime.Now;
            categories.ModifiedByName = createdByName;
            await _unitOfWork.Categories.AddAsync(categories).ContinueWith(t => _unitOfWork.SaveAsync());
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_unitOfWork.Categories.GetAll());
        }

        public async Task<IDataResult<CategoryListDto>> GetList()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync();
            if (categories.Count > -1)
            {
                return new SuccessDataResult<CategoryListDto>(new CategoryListDto
                {
                    Categories = categories
                }, Messages.CategoryList);
            }
            return new ErrorDataResult<CategoryListDto>(Messages.ErrorMessages);
        }

        public async  Task<IResult> HardDelete(int categoryId)
        {
            var categories =  await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            if (categories != null)
            {
                await _unitOfWork.Categories.DeleteAsync(categories).ContinueWith(t => _unitOfWork.SaveAsync());
                return new SuccessResult();
                
                
            }
            return new ErrorResult();
        }

        public async  Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            var categories = _mapper.Map<Category>(categoryUpdateDto);
            categories.ModifiedByName = modifiedByName;
            categories.CreatedByName = modifiedByName;
            categories.ModifedDate = DateTime.Now;
            await _unitOfWork.Categories.UpdateAsync(categories).ContinueWith(t => _unitOfWork.SaveAsync());
            return new SuccessResult(Messages.CategoryUpdate);
        }
    }
}
