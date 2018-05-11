using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OnlineCrimeRepo.Models
{
    public class Criminal
    {
        public int ID { get; set; }
        [RegularExpression("[a-zA-Z ]+")]
        public string Name { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name="Number of Crimes")]
        public int CrimeRate { get; set;}
        public string Address { get; set; }
        public string Gender { get; set; }
        [Display(Name="Height (format: [feet]'[inches]'')")]
        [RegularExpression("[0-9]+'[0-9]+''")]
        public string Height { get; set; }
        [Display(Name="Weight (in Kgs)")]
        
        public int Weight { get; set; }
        public string Complexion { get; set; }
        [Display(Name = "Eye Color")]
        public string EyeColor { get; set; }

    }
}