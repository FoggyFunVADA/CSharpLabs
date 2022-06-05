namespace PlaneModel
{
    public class Plane
    {
        private string Route;
        public string Brand { get; set; }
        public Wing Wing { get; set; }
        public Chassis Chassis { get; set; }
        public Engine Engine { get; set; }

        public Plane()
        {
            Brand = "";
            Route = "";
            Wing = new Wing();
            Chassis = new Chassis();
            Engine = new Engine();
        }

        public Plane(string brand, double length, double wheelDiameter, double power)
        {
            Brand = brand;
            Route = "";
            Wing = new Wing(length);
            Chassis = new Chassis(wheelDiameter);
            Engine = new Engine(power);
        }

        public void SetRoute(string route)
        {
            Route = route;
        }

        public string GetRoute()
        {
            return Route;
        }

        public string Fly()
        {
            Chassis.IsDown = false;
            Wing.IsConditionOfFlight = true;
            Engine.IsConditionOfFlight = true;
            return $"Самолёт летит по маршруту: {Route}";
        }

        public string Landing()
        {
            Chassis.IsDown = true;
            Wing.IsConditionOfFlight = false;
            Engine.IsConditionOfFlight = false;
            if (Wing.Length > 7 && Chassis.WheelDiameter > 30 && Engine.Power > 200)
                return "Ввиду отличных технических характеристик самолёт закончил полёт раньше, чем это было запланировано";
            return $"Самолёт закончил полёт по маршруту: {Route}";
        }

        public override string ToString()
        {
            return $"Технические характеристики самолёта: \r\n Бренд: {Brand}, \r\n Длина крыла (в м.): {Wing.Length}, \r\n " +
                $"Диаметр колёс шасси (в см.): {Chassis.WheelDiameter}, \r\n Мощность двигателя (в л.с.): {Engine.Power}";
        }

    }
}
