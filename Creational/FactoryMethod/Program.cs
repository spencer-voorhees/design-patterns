using FactoryMethod;

INotificationFactory factory;
INotification notification;

// Create and send an email notification 
factory = new EmailNotificationFactory();
notification = factory.Create();
notification.Send("Thanks for subscribing!");

// Create and send an SMS notification 
factory = new SmsNotificationFactory();
notification = factory.Create();
notification.Send("Your verification code is: 1337");
