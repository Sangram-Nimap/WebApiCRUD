using ApiCrud.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data
{
    public class AppDbConnection :DbContext
    {
        public AppDbConnection(DbContextOptions<AppDbConnection> options) :base(options) { }

        public DbSet<Student> students { get; set; }

    }
}
