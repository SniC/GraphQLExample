using System.Collections.Generic;

namespace GraphQLExample.Domain
{
    public class CarOwner : Entity
    {
        private CarOwner()
        {
            this.CarCollection = new List<Car>();
            this.Name = default!;
        }

        public CarOwner(string name) : this()
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public virtual List<Car> CarCollection { get; private set; }

        public Car AddCarToCollection(string brand, string model)
        {
            var car = new Car(brand, model);
            CarCollection.Add(car);
            return car;
        }
    }
}
