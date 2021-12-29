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
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpPost("post")]
        public IActionResult Post(ColorAddDto colorAddDto,string createdName)
        {
            var color = _colorService.Add(colorAddDto);
            if (color != null)
            {
                return Ok(color.Result);
            }
            return BadRequest(color.Result);
        }
    }
}
