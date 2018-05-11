using Microsoft.EntityFrameworkCore;

namespace OnlineCrimeRepo.Models
{
    public class OrpContext : DbContext
    {
        public OrpContext (DbContextOptions<OrpContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineCrimeRepo.Models.Criminal> Criminal { get; set; }
        public DbSet<OnlineCrimeRepo.Models.Cop> Cop { get; set; }
    }
}