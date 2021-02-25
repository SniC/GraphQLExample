using GraphQLExample.Domain;
using Microsoft.EntityFrameworkCore;

namespace GraphQLExample
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-many: CarOwner <-> Car
            modelBuilder
                .Entity<CarOwner>()
                .HasMany(ca => ca.CarCollection)
                .WithOne(c => c.CarOwner);
        }

        public DbSet<CarOwner> CarOwners { get; set; } = default!;

        public DbSet<Car> Cars { get; set; } = default!;
    }
}
