using HotChocolate.Types;
using WebApplication8.Domain;

namespace WebApplication9.Types
{
    public class CarOwnerType : ObjectType<CarOwner>
    {
        protected override void Configure(IObjectTypeDescriptor<CarOwner> descriptor)
        {
            descriptor.BindFieldsExplicitly();
            descriptor.Field(x => x.Id);
            descriptor.Field(x => x.Name);
            descriptor.Field(x => x.CarCollection).UseFiltering();
        }
    }
}
