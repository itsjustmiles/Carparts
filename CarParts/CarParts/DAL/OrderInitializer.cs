using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CarParts.Models;

namespace CarParts.DAL
    {
        public class OrderIntializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<OrderContext>
        {
            protected override void Seed(OrderContext context)
            {
                var Customers = new List<Customers>
            {
            new Customers{FirstMidName="Carson",LastName="Alexander",OrderDate=DateTime.Parse("2014-03-27")},
            new Customers{FirstMidName="Meredith",LastName="Alonso",OrderDate=DateTime.Parse("2014-05-31")},
            new Customers{FirstMidName="Arturo",LastName="Anand",OrderDate=DateTime.Parse("2014-01-22")},
            new Customers{FirstMidName="Gytis",LastName="Barzdukas",OrderDate=DateTime.Parse("2014-02-11")},
            new Customers{FirstMidName="Yan",LastName="Li",OrderDate=DateTime.Parse("2014-08-12")},
            new Customers{FirstMidName="Peggy",LastName="Justice",OrderDate=DateTime.Parse("2013-03-01")},
            new Customers{FirstMidName="Laura",LastName="Norman",OrderDate=DateTime.Parse("2013-04-19")},
            new Customers{FirstMidName="Nino",LastName="Olivetto",OrderDate=DateTime.Parse("2012-09-01")}
            };

                Customers.ForEach(s => context.Customers.Add(s));
                context.SaveChanges();
                var Parts = new List<Parts>
            {
            new Parts{PartID=1050,Title="Ford Muffler",Price=30.00,},
            new Parts{PartID=4022,Title="Chrysler Muffler",Price=30.00,},
            new Parts{PartID=4041,Title="Generic Muffler",Price=20.00,},
            new Parts{PartID=1045,Title="Ford Exhaust Pipe",Price=40.00,},
            new Parts{PartID=3141,Title="Chrysler Exhaust Pipe",Price=40.00,},
            new Parts{PartID=2021,Title="Generic Exhaust Pipe",Price=30.00,},
            new Parts{PartID=2042,Title="Belt",Price=10.00,}
            };
                Parts.ForEach(s => context.Parts.Add(s));
                context.SaveChanges();
                var Orders = new List<Order> 
            {
            new Order{CustomerID=1,PartID=1050},
            new Order{CustomerID=1,PartID=4022},
            new Order{CustomerID=1,PartID=4041},
            new Order{CustomerID=2,PartID=1045},
            new Order{CustomerID=2,PartID=3141},
            new Order{CustomerID=2,PartID=2021},
            new Order{CustomerID=3,PartID=1050},
            new Order{CustomerID=4,PartID=1050},
            new Order{CustomerID=4,PartID=4022},
            new Order{CustomerID=5,PartID=4041},
            new Order{CustomerID=6,PartID=1045}, 
            new Order{CustomerID=7,PartID=3141},
            };
                Orders.ForEach(s => context.Orders.Add(s));
                context.SaveChanges();
            }
        }
    }

    