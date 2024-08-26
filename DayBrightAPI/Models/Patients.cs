using System;
using System.Collections.Generic;

namespace DayBrightAPI.Models
{
    public partial class Patients
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime DateOfRegistration { get; set; }
        public bool? IsActive { get; set; }
    }
}
