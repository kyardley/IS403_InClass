using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCSite.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please indicate if you will attend")]
        public bool? WillAttend { get; set; }
    }
}