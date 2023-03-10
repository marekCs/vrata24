using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Vrata24.Api.Dtos;
using Vrata24.Core.Entities;

namespace Vrata24.Api.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
            .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
            .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
            .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>())
            ;
        }
    }
}