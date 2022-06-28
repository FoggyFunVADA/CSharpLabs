using System;
using System.Threading.Tasks;

namespace ObjectsModel
{
    public class Operator : Object
    {
        public Quadrocopter Quadrocopter { get; set; }

        public Operator(double coordinateX, double coordinateY, Action<string> messages) : base(messages)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            Quadrocopter = null;
        }

        public async Task FlightСontrol()
        {
            Messages("<Оператор контролирует полёт квадрокоптера \"" + Quadrocopter.Name + "\">");
            await Quadrocopter.Fly();
        }

        public override async void StartOfWork()
        {
            while (!IsWorking)
            {
                Messages("<Оператор включил пульт управления квадрокоптером \"" + Quadrocopter.Name + "\">");
                await Task.Delay(3000);
                await FlightСontrol();
                await Task.Delay(6000);
            }
        }
    }
}
