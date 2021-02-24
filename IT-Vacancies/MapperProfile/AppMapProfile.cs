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
                .ReverseMap();
        }
    }
}
