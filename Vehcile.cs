using System;

class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }

    public void StartEngine()
    {
        Console.WriteLine($"Starting the engine of {Make} {Model}...");
    }

    public void StopEngine()
    {
        Console.WriteLine($"Stopping the engine of {Make} {Model}...");
    }
}
