namespace FactoryMethod
{
    public class EmailNotificationFactory : INotificationFactory
    {
        public INotification Create() => new EmailNotification();
    }
}