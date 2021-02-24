using HotChocolate;
using HotChocolate.Data;
using System.Linq;
using WebApplication8.Domain;

namespace WebApplication9
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
