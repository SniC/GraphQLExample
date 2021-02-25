using GraphQLExample.Domain;
using HotChocolate;
using HotChocolate.Data;
using System.Linq;

namespace GraphQLExample
{
    public class Query
    {
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<CarOwner> CarOwners([ScopedService] ApplicationDbContext dbContext) => dbContext.CarOwners;

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Car> Cars([ScopedService] ApplicationDbContext dbContext) => dbContext.Cars;
    }
}
