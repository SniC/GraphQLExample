using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace GraphQLExample.Types
{
    public class QueryType : ObjectType
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Field("carowners")
                .Type<ListType<NonNullType<CarOwnerType>>>()
                .Resolver(async (context) =>
                {
                    var dbContext = context.Service<ExampleContext>();
                    return await dbContext.CarOwners.ToListAsync();
                });
        }
    }
}
