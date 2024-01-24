using Dating_APP.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dating_APP.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options) { }

        public DbSet<User> Users { get; set; }

    }
}
