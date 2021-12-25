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
   public  class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductAddDto, Productt>().ForMember(dest=>dest.CreatedDate,opt=>opt.MapFrom(x=>DateTime.Now));
            CreateMap<ProductUpdateDto, Productt>().ForMember(dest=>dest.ModifedDate,opt=>opt.MapFrom(x=>DateTime.Now));
        }
    }
}
