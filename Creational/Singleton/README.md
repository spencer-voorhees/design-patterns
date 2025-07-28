## Singleton - Logger

This example demonstrates the Singleton pattern using a simple `Logger` class.

**Real-world context:**
A logger is often used as a globally shared utility that writes logs across the application. You typically want only one instance of it, so all log output is consistent and managed in a single place.

**Key points:**
- Only one `Logger` instance is ever created.
- Accessed through `Logger.Instance`.
- Simplified for clarity (not thread-safe).