﻿namespace DayBrightAPI.Models
{
    public class Nurses
    {
        public Guid Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfHire { get; set; }
        public bool IsActive { get; set; } 
    }
}
