using System;
using System.Numerics;

class CarsCatalog
{
    Car[] cars;
    public CarsCatalog (Car[] cars)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            this.cars[i] = cars[i];
        }
    }
    
}
public class Car
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


    public override string ToString()
    {
        return "Car: " + Name ;
    }
}




namespace part1
{
    class program
    {
        static void Main(string[] args)
        {

            Car car = new Car ("Mystang", "Дизель", 240 );
            Console.WriteLine(car);

        }
    }
}