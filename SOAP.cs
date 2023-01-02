using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireFrames
{
    internal class SOAP
    {
        public string PetID { get; set; }
        [Required(ErrorMessage = "PetID is required")]
        [Range(1, 200, ErrorMessage = "Please enter a valid PetID")]
        public string Subjective { get; set;}
        public string Objective { get; set;}
        public string Assessment { get; set;}
        public string Plan__ { get; set;}
        public string Date { get; set;}
    }
}
