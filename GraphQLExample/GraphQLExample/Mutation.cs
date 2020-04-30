using GraphQLExample.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExample
{
    public class Mutation
    {
        private readonly ExampleContext dbContext;

        public Mutation(ExampleContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<CarOwner> CreateCarOwner(string name)
        {
            var carOwner = new CarOwner(name);
            dbContext.CarOwners.Add(carOwner);
            await dbContext.SaveChangesAsync();
            return carOwner;
        }

        public async Task<Car> AddCar(Guid ownerId, string brand, string model)
        {
            var carOwner = dbContext.CarOwners.FirstOrDefault(x => x.Id == ownerId);
            var car = carOwner.AddCarToCollection(brand, model);
            await dbContext.SaveChangesAsync();
            return car;
        }
    }
}
