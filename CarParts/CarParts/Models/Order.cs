using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarParts.Models
{
    public class Order
    {
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public int PartID { get; set; }
        public int CarID { get; set; }

        public virtual Order order { get; set; }
        public virtual Customers Customers { get; set; }
    }
}