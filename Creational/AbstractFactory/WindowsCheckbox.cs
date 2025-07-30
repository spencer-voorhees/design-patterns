namespace AbstractFactory
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Windows Checkbox");
    }
}