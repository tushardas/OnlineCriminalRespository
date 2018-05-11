using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OnlineCrimeRepo.Models
{
    public class CopDesignationViewModel
    {
        public List<Cop> cops;
        public SelectList designations;
        public SelectList stations;
        public string copDesignation { get; set; }
        public string copStation {get; set;}
    }
}