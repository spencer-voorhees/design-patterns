## Abstract Factory – Cross-Platform UI Kit

This example demonstrates the Abstract Factory pattern using a simplified cross-platform UI system.

**Real-world context:**  
A UI framework needs to support multiple operating systems (e.g., macOS and Windows). Each OS has its own button and checkbox styles. Instead of hardcoding these in the app, it uses an abstract factory to create the appropriate controls based on the selected platform.

**Key points:**
- Defines abstract interfaces for `IButton`, `ICheckbox`, and `IUIFactory`.
- Each concrete factory (`MacUIFactory`, `WindowsUIFactory`) creates a matching set of controls.
- The client (`Application`) is decoupled from the specific UI element implementations.