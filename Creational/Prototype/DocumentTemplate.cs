namespace Prototype
{
    public class DocumentTemplate
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public DocumentTemplate(string title, string body)
        {
            Title = title;
            Body = body;
        }

        public DocumentTemplate Clone()
        {
            return new DocumentTemplate(Title, Body);
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine();
        }
    }
}