using System;


interface IVehicle
{
    void Start();
    void Stop();
}


class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped");
    }
}


class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike started");
    }

    public void Stop()
    {
        Console.WriteLine("Bike stopped");
    }
}


class Program
{
    static void Main()
    {
        IVehicle myCar = new Car();
        IVehicle myBike = new Bike();

        myCar.Start();
        myCar.Stop();

        myBike.Start();
    }
}
