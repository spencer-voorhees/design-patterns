namespace DesignPatterns.Creational.Singleton
{
    public class Logger
    {
        private static readonly Lazy<Logger> _instance = new(() => new Logger());

        private readonly object _lock = new();

        public static Logger Instance = _instance.Value;

        private Logger() { }

        public void Log(string message)
        {
            lock (_lock)
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                Console.WriteLine($"[{timestamp}] {message}");
            }
        }
    }
}