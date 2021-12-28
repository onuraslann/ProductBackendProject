using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Business.Services.Abstract;
using Product.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categorySerive;

        public CategoriesController(ICategoryService categorySerive)
        {
            _categorySerive = categorySerive;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var categories = _categorySerive.GetList();
            if (categories != null)
            {
                return Ok(categories.Result);
            }
            return BadRequest(categories.Result);
        }
        [HttpPost("add")]
        
        public  IActionResult Add(CategoryAddDto categoryAddDto)
        {
            var categories =  _categorySerive.Add(categoryAddDto);
            if (categories != null)
            {
                return Ok(categories.Result);
            }
            return BadRequest(categories.Result);
        }
    }
}
