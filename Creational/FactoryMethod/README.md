## Factory Method – Notification Sender

This example demonstrates the Factory Method pattern using a simple notification system.

**Real-world context:**  
A system needs to send different types of notifications (like Email and SMS). Instead of instantiating these directly, it delegates creation to factory classes. This allows the system to remain decoupled from the specific notification implementations.

**Key points:**
- Uses a common `INotification` interface.
- Concrete factories (`EmailNotificationFactory`, `SmsNotificationFactory`) return different types of notifications.
- The calling code remains unaware of the specific class being instantiated.