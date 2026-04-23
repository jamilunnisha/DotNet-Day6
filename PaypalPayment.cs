public class PaypalPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Paid using PayPal");
    }
}