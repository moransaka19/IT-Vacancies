using DAL.Interfaces;
using DAL.Repositories;
using Domain;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class VacancyService : IVacancyService
    {
        private IRecruiterRepository _recruiterRepostory;
        private ICompanyRepository _companyRepostory;
        private IVacancyRepository _vacancyRepository;

        public VacancyService(IRecruiterRepository recruiterRepostory, ICompanyRepository companyRepostory, IVacancyRepository vacancyRepository)
        {
            _recruiterRepostory = recruiterRepostory;
            _companyRepostory = companyRepostory;
            _vacancyRepository = vacancyRepository;
        }


        public IEnumerable<Vacancy> GetAllVacansies()
        {
            return _vacancyRepository.GetAll();
        }

        public Recruiter GetRecruterByVacancy(Vacancy vacancy)
        {
            return _recruiterRepostory.GetById(vacancy.Recruiter.Id);
        }

        public Company GetCompanyByVacancy(Vacancy vacancy)
        {
            return _companyRepostory.GetById(vacancy.Company.Id);
        }
    }
}
