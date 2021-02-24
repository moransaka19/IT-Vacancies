using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT_Vacancies.Models
{
    public class VacancyViewModel
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string RecruiterName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
