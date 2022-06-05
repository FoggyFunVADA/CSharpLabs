namespace PlaneModel
{
    public class Chassis
    {
        public bool IsDown{ get; set; }
        public double WheelDiameter { get; set; }

        public Chassis()
        {
            IsDown = true;
            WheelDiameter = 0.0;
        }

        public Chassis(double wheelDiameter)
        {
            IsDown = true;
            WheelDiameter = wheelDiameter;
        }
    }
}
