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
        public int CustomerID { get; set; }
        public string Cust_First_Name { get; set; }
        public string Cust_Last_Name { get; set; }
        public string Cust_Adress { get; set; }
        public string Cust_City { get; set; }
        public string Cust_State { get; set; }
        public string Cust_Zip { get; set; }
        public string Cust_Phone { get; set; }

        
    }
}