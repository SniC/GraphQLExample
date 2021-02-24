using HotChocolate.Types;
using WebApplication8.Domain;

namespace WebApplication9.Types
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
