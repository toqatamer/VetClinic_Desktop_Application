using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireFrames
{
    internal class NurseAddCredit
    {
        public string PetID { get; set; }
        [Required(ErrorMessage = "PetID is required")]
        [Range(1, 200, ErrorMessage = "Please enter a valid PetID")]
        public string Credit { get; set; }
        [Required(ErrorMessage = "Value is required")]
        [Range(0.1, 199, ErrorMessage = "Please enter a valid value")]

        public string pet { get; set; }
    }
}
