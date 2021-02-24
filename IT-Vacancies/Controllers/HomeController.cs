using AutoMapper;
using BLL;
using Domain;
using IT_Vacancies.MapperProfile;
using IT_Vacancies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IT_Vacancies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMapper _mapper;
        private IVacancyService _vacancyService;

        public HomeController(ILogger<HomeController> logger, IMapper mapper, IVacancyService vacancyService)
        {
            _logger = logger;
            _mapper = mapper;
            _vacancyService = vacancyService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vacancy()
        {
            var vacancies = _vacancyService.GetAllVacansies();
            var vacanciesViewModel = _mapper.Map<IEnumerable<Vacancy>, IEnumerable<VacancyViewModel>>(vacancies);

            return View(vacanciesViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
