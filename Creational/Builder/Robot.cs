namespace Builder
{
    public class Robot(string head, string arms, string legs)
    {
        public string Head { get; } = head;
        public string Arms { get; } = arms;
        public string Legs { get; } = legs;

        public override string ToString()
        {
            return $"Robot Configuration:\n" +
                   $"- Head: {Head}\n" +
                   $"- Arms: {Arms}\n" +
                   $"- Legs: {Legs}\n";
        }
    }
}