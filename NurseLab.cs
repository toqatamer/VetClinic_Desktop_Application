using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireFrames
{
    internal class NurseLab
    {

        public string PetID { get; set; }
        [Required(ErrorMessage = "PetID is required")]
        [Range(1, 200, ErrorMessage = "Please enter a valid PetID")]
        public string ChooseTime { get; set; }
        [Required(ErrorMessage = "Time is required")]

        public string lab { get; set; }

    }
}
