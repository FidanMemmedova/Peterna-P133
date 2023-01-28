using Microsoft.EntityFrameworkCore;
using peterna.Models;

namespace peterna.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
        }
        public DbSet<Service> Services { get; set; }
    }
}
