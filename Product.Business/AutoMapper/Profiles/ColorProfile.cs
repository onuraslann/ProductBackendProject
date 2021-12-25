using AutoMapper;
using Product.Entities.Concrete;
using Product.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business.AutoMapper.Profiles
{
    public class ColorProfile:Profile
    {
        public ColorProfile()
        {
            CreateMap<ColorAddDto, Color>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ColorUpdateDto, Color>().ForMember(dest => dest.ModifedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
