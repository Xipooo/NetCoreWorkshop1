using Microsoft.EntityFrameworkCore;
using NetCoreWorkshop1.Models;

namespace NetCoreWorkshop1.Contexts
{
    public class NetCoreWorkshopContext : DbContext
    {
        public NetCoreWorkshopContext(DbContextOptions<NetCoreWorkshopContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Person> People { get; set; }

    }
}