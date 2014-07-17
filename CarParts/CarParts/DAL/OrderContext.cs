using CarParts.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CarParts.DAL
{
    public class OrderContext : DbContext
    {
        public OrderContext()
            : base("OrderContext")
        {
        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Parts> Parts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}