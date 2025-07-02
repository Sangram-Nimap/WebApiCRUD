using ApiCrudChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCrudChallenge.Data
{
    public class AppDbConnection: DbContext
    {
        public AppDbConnection(DbContextOptions<AppDbConnection> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<OrderItems> orders { get; set; }
    }
}
