using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WireFrames
{
    internal class Consultions
    {
        public string PetID { get; set; }
        [Required(ErrorMessage = "The pet ID is required")]
        [Range(1, 200, ErrorMessage = "Please enter a valid PetID")]
        public string ChooseTime { get; set; }
    }
}
