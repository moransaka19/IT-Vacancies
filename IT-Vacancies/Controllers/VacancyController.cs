using AutoMapper;
using BLL;
using Domain;
using IT_Vacancies.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT_Vacancies.Controllers
{
    public class VacancyController : Controller
    {
        private IMapper _mapper;
        private IVacancyService _vacancyService;

        public VacancyController(IVacancyService vacancyService, IMapper mapper)
        {
            _vacancyService = vacancyService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var vacancies = _vacancyService.GetAllVacancies();
            var vacanciesViewModel = _mapper.Map<IEnumerable<Vacancy>, IEnumerable<VacancyViewModel>>(vacancies);

            return View(vacanciesViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VacancyViewModel model)
        {
            var vacancy = _mapper.Map<Vacancy>(model);
            _vacancyService.AddNewVacancy(vacancy);
            

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var vacancy = _vacancyService.GetById(id);
            var vacancyViewModel = _mapper.Map<VacancyViewModel>(vacancy);
            return View(vacancyViewModel);
        }

        [HttpPost]
        public IActionResult Edit(VacancyViewModel model)
        {
            var vacancy = _mapper.Map<Vacancy>(model);
            _vacancyService.UpdateVacancy(vacancy);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var vacancy = _vacancyService.GetById(id);
            var vacancyViewModel = _mapper.Map<VacancyViewModel>(vacancy);
            return View(vacancyViewModel);
        }

        [HttpPost]
        public IActionResult Delete(VacancyViewModel model)
        {
            var vacancy = _mapper.Map<Vacancy>(model);
            _vacancyService.DeleteVacancy(vacancy);

            return RedirectToAction(nameof(Index));
        }
    }
}
