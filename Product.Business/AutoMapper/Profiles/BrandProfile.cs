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
   public class BrandProfile:Profile
    {
        public BrandProfile()
        {
            CreateMap<BrandAddDto, Brand>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<BrandUpdateDto, Brand>().ForMember(dest => dest.ModifedDate, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}
