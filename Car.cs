public class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car starting...");
    }

    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}