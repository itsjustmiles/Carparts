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
        public DateTime OrderDate
    {
   get
        {
         return this.dateCreated.HasValue
         ? this.dateCreated.Value
         : DateTime.Now;
    }

     set { this.dateCreated = value; }
    }

    private DateTime? dateCreated = null;
        
        public String Address { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
    }
} 