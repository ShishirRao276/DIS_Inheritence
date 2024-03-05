using System;
class Program
{
    static void Main(string[] args)
    {
        // Create a car
        var myCar = new Car
        {
            Make = "Toyota",
            Model = "Camry",
            Year = 2022,
            BodyType = "Sedan"
        };


        myCar.StartEngine();
        myCar.Drive();
        myCar.StopEngine();
    }
}
