using GraphQLExample.Domain;
using HotChocolate;
using HotChocolate.Data;
using System;

namespace GraphQLExample
{
    public class Mutation
    {
        [UseDbContext(typeof(ApplicationDbContext))]
        public CarOwner AddCarOwner(string name, [ScopedService] ApplicationDbContext dbContext)
        {
            var carOwner = new CarOwner(name);
            dbContext.CarOwners.Add(carOwner);
            dbContext.SaveChanges();
            return carOwner;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        public Car AddCarToCollection(Guid carOwnerId, string brand, string model, [ScopedService] ApplicationDbContext dbContext)
        {
            var carOwner = dbContext.CarOwners.Find(carOwnerId);
            var car = carOwner.AddCarToCollection(brand, model);
            dbContext.SaveChanges();
            return car;
        }
    }
}
