using AbstractFactory;

// Create the Mac application and render the UI
IUIFactory macFactory = new MacUIFactory();
Application macApp = new(macFactory);
macApp.RenderUI();

// Divider for output clarity
Console.WriteLine("----------------");

// Create the Windows application and render the UI
IUIFactory windowsFactory = new WindowsUIFactory();
Application windowsApp = new(windowsFactory);
windowsApp.RenderUI();
