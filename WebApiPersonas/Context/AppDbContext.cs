using Microsoft.EntityFrameworkCore;
using WebApiPersonas.Models;

namespace WebApiPersonas.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
