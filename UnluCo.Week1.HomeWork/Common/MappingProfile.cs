using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Week1.HomeWork.CatOperations.GetByIdCats;
using UnluCo.Week1.HomeWork.CatOperations.GetCats;
using UnluCo.Week1.HomeWork.CatOperations.OrderByCat;

using static UnluCo.Week1.HomeWork.CatOperations.CreateCat.AddCatCommand;

namespace UnluCo.Week1.HomeWork.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddCatModel, Cats>(); // AddCatModel objesi Cats objesine maplenebilir oldu.
            CreateMap<Cats, ByIdCatsViewModel>().ForMember(dest => dest.Gender, opt=>opt.MapFrom(src=>((GenderEnum)src.GenderId).ToString()));
            CreateMap<Cats, CatsViewModel>().ForMember(dest => dest.Gender, opt => opt.MapFrom(src => ((GenderEnum)src.GenderId).ToString()));
            CreateMap<Cats, OrderByCatViewModel>().ForMember(dest => dest.Gender, opt => opt.MapFrom(src => ((GenderEnum)src.GenderId).ToString()));
            
        }



    }
}
