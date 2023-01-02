using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WireFrames
{
    internal class DoctorSignIn
    {

        public string ID { get; set; }
        [Required(ErrorMessage = "Your ID is required")]
        [StringLength(1)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Your Password is required")]
        public string Email { get; set; }
    }
}
