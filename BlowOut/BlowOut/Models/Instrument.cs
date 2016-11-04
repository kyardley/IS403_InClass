using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Instrument") ]
    public class Instrument
    {
        [Key]
        public int Inst_ID { get; set; }

        [Required(ErrorMessage = "Please enter a Description")]
        [DisplayName("Instrument")]
        public string Inst_Description { get; set; }
        
        [Required(ErrorMessage = "Please enter a Type")]
        [DisplayName("Type")]
        public string Inst_Type { get; set; }
        
        [Required(ErrorMessage = "Please enter a Price")]
        [DisplayName("Price")]
        public string Inst_Price { get; set; }

        public string Cust_ID { get; set; }
    }
}