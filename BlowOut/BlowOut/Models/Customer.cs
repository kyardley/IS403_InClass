using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        
        [DisplayName("First Name:")]
        [Required(ErrorMessage="Please enter a First Name")]
        public string Cust_FirstName { get; set; }

        [DisplayName("Last Name:")]
        [Required(ErrorMessage = "Please enter a Last Name")]
        public string Cust_LastName { get; set; }

        [DisplayName("Street:")]
        [Required(ErrorMessage = "Please enter a Street Address")]
        public string Cust_Address { get; set; }

        [DisplayName("City:")]
        [Required(ErrorMessage = "Please enter a City")]
        public string Cust_City { get; set; }

        [DisplayName("State:")]
        [Required(ErrorMessage = "Please enter a State")]
        public string Cust_State { get; set; }

        [DisplayName("Zip Code:")]
        [Required(ErrorMessage = "Please enter a Zip Code")]
        public string Cust_Zip { get; set; }

        [DisplayName("Email:")]
        [Required(ErrorMessage = "Please enter an Email")]
        public string Cust_Email { get; set; }

        [DisplayName("Phone Number:")]
        [Required(ErrorMessage = "Please enter a Phone Number")]
        public string Cust_Phone { get; set; }
    }
}