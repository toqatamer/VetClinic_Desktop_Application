using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireFrames
{
    internal class NurseAdd
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string NationalID { get; set; }
        [Required(ErrorMessage = "National ID is required")]
        [StringLength(14)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string PhoneNumber { get; set; }
        //setting phone number starts with 01 then takes range from 0 to 9
        [RegularExpression("(01) [0-9] {9}", ErrorMessage = "Please enter a valid Egyptain phone number")]
        [StringLength(11)]
        public string RegistrationDate { get; set; }
        [Required(ErrorMessage = "Date is required")]
        public string DATE { get; set; }
    }
}
