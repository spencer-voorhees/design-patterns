namespace FactoryMethod
{
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sent SMS: {message}");
        }
    }
}