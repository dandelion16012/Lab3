using System;
using System.Drawing;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

class CarsCatalog
{
    public Car[] cars;
    public CarsCatalog(Car[] cars)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            this.cars[i] = cars[i];
        }
    }

    public int this[int index]
    {
        get { return cars[index].getinf(); }

    }
}
public class Car : IEquatable<Car>
{
    string Name;
    string Engine;
    int MaxSpeed;
    public Car (string Name,string Engine, int MaxSpeed)
    {
        this .Name = Name;
        this .Engine = Engine;
        this .MaxSpeed = MaxSpeed;
    }
    public bool Equals(Car? car)
    {
        return (this.Name, this.Engine, this.MaxSpeed) ==
            (car?.Name, car?.Engine, car?.MaxSpeed);
    }


    public override string ToString()
    {
        return "Car: " + Name ;
    }
    public int getinf()
    {
        Console.WriteLine($"Name\t {Name}\t Engine{Engine}");
        return 0;
    }
}




namespace part2
{
    class program
    {
        static void Main(string[] args)
        {

            Car car = new Car ("Mystang", "Дизель", 240 );
            Console.WriteLine(car);
            Car carOne = new Car("BMW", "Бензин",300);
            Car carTwo = new Car("BMW", "Бензин", 280);
            Car carThree = new Car("BMW", "Бензин", 280);
            Car[] ar = { carOne, carTwo, carThree };

            Console.WriteLine(carOne.Equals(carTwo));
            Console.WriteLine(carThree.Equals(carTwo));
            CarsCatalog arr = new CarsCatalog(ar);
            arr[2];

            Console.ReadKey();

        }
    }
}