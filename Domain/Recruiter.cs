using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Recruiter : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
