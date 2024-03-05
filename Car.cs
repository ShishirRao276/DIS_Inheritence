class Car : Vehicle
{
    public int Year { get; set; }
    public string BodyType { get; set; }

    public void Drive()
    {
        Console.WriteLine($"Driving the {Year} {Make} {Model} ({BodyType})");
    }
}
