public class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid " + amount + " using Credit Card");
    }
}