
using System;
using System.ComponentModel.DataAnnotations;

namespace InsuranceQuoteApp.Models
{
    public class Insuree
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Car Year")]
        public int CarYear { get; set; }

        [Required]
        [Display(Name = "Car Make")]
        public string CarMake { get; set; }

        [Required]
        [Display(Name = "Car Model")]
        public string CarModel { get; set; }

        [Required]
        [Display(Name = "Speeding Tickets")]
        public int SpeedingTickets { get; set; }

        [Required]
        public bool DUI { get; set; }

        [Required]
        [Display(Name = "Full Coverage")]
        public bool CoverageType { get; set; }

        public decimal Quote { get; set; }
    }
}
