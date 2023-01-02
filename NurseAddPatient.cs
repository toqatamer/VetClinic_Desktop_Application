using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireFrames
{
    internal class NurseAddPatient
    {
        public string PetName { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string PetType { get; set; }
        [Required(ErrorMessage = "Type is required")]
        public string PetGender { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public string Allergies { get; set; }
        public string PrevDiseases { get; set; }
        public string Weight { get; set; }
        [Required(ErrorMessage = "Weight is required")]
        [Range(1, 50, ErrorMessage = "Please enter a valid weight from 1 to 50 CM")]
        public string Height { get; set; }
        [Required(ErrorMessage = "Height is required")]
        [Range(15, 120, ErrorMessage = "Please enter a valid height from 15 to 120 KGs")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(0, 15, ErrorMessage = "Please enter a valid age")]
        public string Birthday { get; set;}
    }
}
