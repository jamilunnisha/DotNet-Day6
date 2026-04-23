class Program
{
    static void Main(string[] args)
    {
        // Animal and Dog (Inheritance + Polymorphism)
        Animal animal = new Dog("Tommy");
        animal.Eat();

        ((Dog)animal).Bark();

        Console.WriteLine();

        // Vehicle and Car
        Vehicle vehicle = new Car();
        vehicle.Start();

        ((Car)vehicle).Drive();

        Console.WriteLine();

        // Shape and Circle
        Shape shape = new Circle();
        shape.Draw();

        Console.WriteLine();

        // Interface usage
        IPrinter printer = new Document();
        printer.Print();

        Console.WriteLine();

        // Multiple interface implementations
        IPayment payment1 = new CreditCardPayment();
        payment1.Pay();

        IPayment payment2 = new PaypalPayment();
        payment2.Pay();
    }
}