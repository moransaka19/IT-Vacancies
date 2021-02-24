using Domain;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT_Vacancies.Models
{
    public class VacancyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string RecruiterName { get; set; }

        [RegularExpression(@"^[0-9\-\+]{9,15}$")]
        [MaxLength(11)]
        public string PhoneNumber { get; set; }
    }
}
