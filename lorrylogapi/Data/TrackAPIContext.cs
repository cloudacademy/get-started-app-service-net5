using Microsoft.EntityFrameworkCore;

namespace LorryLogAPI.Data
{
    public class LorryLogAPIContext : DbContext
    {
        public LorryLogAPIContext (DbContextOptions<LorryLogAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
