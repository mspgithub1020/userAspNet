using Microsoft.EntityFrameworkCore;

namespace userAspNet.Models
{
    public class EntidadContext : DbContext
    {
        public EntidadContext(DbContextOptions<EntidadContext> options)
            : base(options)
        {
        }

        public DbSet<User> TodoItems { get; set; }
    }
}