using GraphQLExample.Domain;
using Microsoft.EntityFrameworkCore;

namespace GraphQLExample
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions<ExampleContext> options)
            : base(options)
        {
        }
        public DbSet<CarOwner> CarOwners { get; set; }

        public DbSet<Car> Cars { get; set; }
    }
}
