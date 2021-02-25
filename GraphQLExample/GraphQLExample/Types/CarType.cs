using GraphQLExample.Domain;
using HotChocolate.Types;

namespace GraphQLExample.Types
{
    public class CarType : ObjectType<Car>
    {
        protected override void Configure(IObjectTypeDescriptor<Car> descriptor)
        {
            descriptor.BindFieldsExplicitly();
            descriptor.Field(x => x.Id);
            descriptor.Field(x => x.Model);
            descriptor.Field(x => x.Brand);
            descriptor.Field(x => x.CarOwner);
        }
    }
}
