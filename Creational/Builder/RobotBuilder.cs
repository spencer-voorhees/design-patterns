namespace Builder
{
    public class RobotBuilder()
    {
        private string _head = "Default Head";
        private string _arms = "Default Arms";
        private string _legs = "Default Legs";

        public RobotBuilder SetHead(string head)
        {
            _head = head;
            return this;
        }

        public RobotBuilder SetArms(string arms)
        {
            _arms = arms;
            return this;
        }

        public RobotBuilder SetLegs(string legs)
        {
            _legs = legs;
            return this;
        }

        public Robot Build()
        {
            return new(_head, _arms, _legs);
        }
    }
}