namespace GraphQLExample.Domain
{
    public class Car : Entity
    {
        public Car(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }

        public string Brand { get; private set; }
        public string Model { get; private set; }
    }
}
