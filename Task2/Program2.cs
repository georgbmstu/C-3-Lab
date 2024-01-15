using System;
using System.Collections.Generic;

public class Car : IEquatable<Car>
{
    public string Name { get; set; }
    public string Engine { get; set; }
    public int MaxSpeed { get; set; }

    public override string ToString()
    {
        return Name;
    }

    public bool Equals(Car other)
    {
        if (other == null)
            return false;

        return this.Name == other.Name && this.Engine == other.Engine;
    }
}

public class CarsCatalog
{
    private List<Car> cars;

    public CarsCatalog()
    {
        cars = new List<Car>();
    }

    public Car this[int index]
    {
        get { return cars[index]; }
        set { cars[index] = value; }
    }

    public string GetCarInfo(int index)
    {
        return $"{cars[index].Name}, {cars[index].Engine}";
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void RemoveCar(Car car)
    {
        cars.Remove(car);
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car { Name = "BMW", Engine = "V8", MaxSpeed = 250 };
        Car car2 = new Car { Name = "Mercedes", Engine = "V8", MaxSpeed = 240 };

        Console.WriteLine(car1);
        Console.WriteLine(car2);

        Console.WriteLine(car1.Equals(car2));

        CarsCatalog catalog = new CarsCatalog();
        catalog.AddCar(car1);
        catalog.AddCar(car2);

        Console.WriteLine(catalog[0]);
        Console.WriteLine(catalog.GetCarInfo(1));
    }
}
