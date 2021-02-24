using AutoMapper;
using Domain;
using IT_Vacancies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT_Vacancies.MapperProfile
{
    public class AppMapProfile : Profile
    {
        public AppMapProfile()
        {
            CreateMap<Vacancy, VacancyViewModel>()
                .ForMember(dst => dst.RecruiterName, opt => opt.MapFrom(src => src.RecrutierName))
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Price, opt => opt.MapFrom(src => src.Price))
                .ReverseMap();
        }
    }
}
