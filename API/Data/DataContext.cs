using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        // pass connection string to options to be able to create a connection to the database
        public DataContext(DbContextOptions options) : base(options) {}

        public DbSet<AppUser> Users {get; set;}
    }
}  