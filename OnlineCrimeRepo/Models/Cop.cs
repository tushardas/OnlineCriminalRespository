using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OnlineCrimeRepo.Models
{
    public class Cop
    {
        public int ID { get; set;}
        [RegularExpression("([A-Z]){3}([0-9]){7}")]
        public string CopID {get; set;}
        [RegularExpression("[a-zA-Z ]+")]
        public string Name {get; set;}
        public string Designation {get; set;}
        [Display(Name="Police Station")]
        public string PoliceStation {get; set;}

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [RegularExpression("[0-9]{10}")]
        [Display(Name="Phone Number")]
        public string PhoneNumber {get; set;}
        
        public string Address {get; set;}
    }
}