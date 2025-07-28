namespace FactoryMethod
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sent EMAIL: {message}");
        }
    }
}