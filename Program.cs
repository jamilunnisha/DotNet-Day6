class Program
{
    static void Main(string[] args)
    {
        // Animal and Dog
        Animal animal = new Dog("Tommy");
        animal.Eat();
        ((Dog)animal).Bark();

        // Vehicle and Car
        Vehicle vehicle = new Car();
        vehicle.Start();
        ((Car)vehicle).Drive();

        // Shape and Circle
        Shape shape = new Circle();
        shape.Draw();

        // Interface usage
        IPrinter printer = new Document();
        printer.Print();

        // Multiple implementations
        IPayment payment1 = new CreditCardPayment();
        payment1.Pay();

        IPayment payment2 = new PaypalPayment();
        payment2.Pay();
    }
}