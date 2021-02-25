namespace GraphQLExample.Domain
{
    public class Car : Entity
    {
        private Car()
        {
            this.Brand = default!;
            this.Model = default!;
        }

        public Car(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }

        public string Brand { get; private set; }
        public string Model { get; private set; }

        public virtual CarOwner CarOwner { get; private set; } = default!;
    }
}
