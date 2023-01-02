using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireFrames
{
    internal class PatientSignUp
    {
        public string PatientName { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string PatientNationalID { get; set; }
        [Required(ErrorMessage = "Your National ID is required")]
        [StringLength(14)]
        public string PatientPassword { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string PatientPhone { get; set; }
    }
}
