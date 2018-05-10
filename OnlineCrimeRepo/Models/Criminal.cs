using System;
using System.ComponentModel.DataAnnotations;
namespace OnlineCrimeRepo.Models
{
    public class Criminal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name="Number of Crimes")]
        public int CrimeRate { get; set;}
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Complexion { get; set; }
        [Display(Name = "Eye Color")]
        public string EyeColor { get; set; }

    }
}