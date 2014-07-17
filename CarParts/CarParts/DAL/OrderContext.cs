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

        public DbSet<Customers> Students { get; set; }
        public DbSet<Order> Enrollments { get; set; }
        public DbSet<Parts> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}