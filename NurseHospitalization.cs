using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireFrames
{
    internal class NurseHospitalization
    {
        public string PetID { get; set; }
        [Required(ErrorMessage = "PetID is required")]
        [Range(1, 200, ErrorMessage = "Please enter a valid PetID")]
        public string from__ { get; set; }
        [Required(ErrorMessage = "Date is required")]
        public string to__ { get; set; }
        [Required(ErrorMessage = "Date is required")]
        public string Date { get; set; }

    }
}
