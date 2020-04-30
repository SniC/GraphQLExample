using GraphQLExample.Domain;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GraphQLExample.Types
{
    public class CarOwnerType : ObjectType<CarOwner>
    {
        protected override void Configure(IObjectTypeDescriptor<CarOwner> descriptor)
        {
            descriptor.Field("cars")
                .Type<ListType<CarType>>()
                .Resolver(async (context) =>
                {
                    var dbContext = context.Service<ExampleContext>();
                    var carOwnerId = context.Parent<CarOwner>().Id;
                    var cars = await dbContext.CarOwners
                        .Where(x => x.Id == carOwnerId)
                        .SelectMany(x => x.Cars)
                        .Select(c => c)
                        .ToListAsync();

                    return cars;
                });
        }
    }
}
