using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarParts.Models
{
    public class Customers
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime OrderDate { get; set; }
        public String Address { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
    }
}