using System.Collections.Generic;

namespace GraphQLExample.Domain
{
    public class CarOwner : Entity
    {
        public CarOwner(string name)
        {
            this.Name = name;
            this.Cars = new List<Car>();
        }

        public string Name { get; private set; }
        public List<Car> Cars { get; private set; }

        public Car AddCarToCollection(string brand, string model)
        {
            var car = new Car(brand, model);
            Cars.Add(car);
            return car;
        }
    }
}
