namespace PlaneModel
{
    public class Engine
    {
        public bool IsConditionOfFlight { get; set; }
        public double Power { get; set; }

        public Engine()
        {
            IsConditionOfFlight = false;
            Power = 0.0;
        }

        public Engine(double power)
        {
            IsConditionOfFlight = false;
            Power = power;
        }
    }
}
