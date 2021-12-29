using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Business.Services.Abstract;
using Product.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpPost("post")]
        public IActionResult Post(BrandAddDto brandAddDto, string createdByName)
        {
            var brand = _brandService.Add(brandAddDto,createdByName);
            if (brand!=null)
            {
                return Ok(brand.Result);
            }
            return BadRequest(brand.Result);
        }
    }
}
