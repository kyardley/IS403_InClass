using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Cust_ID { get; set; }
        [Required(ErrorMessage="Please enter a First Name")]
        public string Cust_FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a Last Name")]
        public string Cust_LastName { get; set; }
        [Required(ErrorMessage = "Please enter a Street Address")]
        public string Cust_Address { get; set; }
        [Required(ErrorMessage = "Please enter a City")]
        public string Cust_City { get; set; }
        [Required(ErrorMessage = "Please enter a State")]
        public string Cust_State { get; set; }
        [Required(ErrorMessage = "Please enter a Zip Code")]
        public string Cust_Zip { get; set; }
        [Required(ErrorMessage = "Please enter a Phone Number")]
        public string Cust_Phone { get; set; }
    }
}