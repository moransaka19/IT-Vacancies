using System;

namespace Domain
{
    public class Vacancy : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string RecrutierName { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
    }
}
