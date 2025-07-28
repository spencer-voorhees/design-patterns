namespace FactoryMethod
{
    public class SmsNotificationFactory : INotificationFactory
    {
        public INotification Create() => new SmsNotification();
    }
}