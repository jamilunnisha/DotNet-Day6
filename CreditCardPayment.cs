public class CreditCardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paid using Credit Card");
    }
}