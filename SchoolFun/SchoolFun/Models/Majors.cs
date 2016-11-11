using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolFun.Models
{
    [Table("Majors")]
    public class Majors
    {
        [Key]
        public String Major_ID { get; set; }
        public String Major_Description { get; set; }

    }
}