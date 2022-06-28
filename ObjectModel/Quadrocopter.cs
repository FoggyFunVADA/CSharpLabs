using System;
using System.Threading.Tasks;

namespace ObjectsModel
{
    public class Quadrocopter : MovingObject
    {
        private readonly object QuadrocopterLocker;
        public bool WaitingForMechanic { get; set; }
        public bool IsBroken { get; set; }

        public Quadrocopter(object quadrocopterLocker, double startCoordinateX, double startCoordinateY, Action<string> messages) : 
            base(startCoordinateX, startCoordinateY, messages)
        {
            QuadrocopterLocker = quadrocopterLocker;
        }

        public void StartOfFlight()
        {
            lock (QuadrocopterLocker)
            {
                MovingByCoordinateY = StartCoordinateY - 300;
                IsMoving = true;
            }
        }

        public void EndOfFlight()
        {
            Messages("<Полёт квадрокоптера \"" + Name + "\" окончен!>");
            lock (QuadrocopterLocker)
            {
                MovingByCoordinateY = StartCoordinateY;
                MovingByCoordinateX = StartCoordinateX;
            }
        }

        public async Task WaitQuadrocopterUp()
        {
            bool quadrocopterIsUp = false;
            while (!quadrocopterIsUp)
            {
                await Task.Delay(100);
                lock (QuadrocopterLocker)
                {
                    quadrocopterIsUp = EndOfWork();
                }
            }
        }

        public async Task WaitQuadrocopterDown()
        {
            bool quadrocopterIsDown = false;
            while (!quadrocopterIsDown)
            {
                await Task.Delay(100);
                lock (QuadrocopterLocker)
                {
                    quadrocopterIsDown = EndOfWork();
                }
            }
        }

        private async Task Breakdown()
        {
            bool quadrocopterIsDown = false;
            MovingByCoordinateX = CoordinateX;
            MovingByCoordinateY = StartCoordinateY;
            while (!quadrocopterIsDown)
            {
                await Task.Delay(100);
                lock (QuadrocopterLocker)
                {
                    quadrocopterIsDown = EndOfWork();
                }
            }
        }

        public async Task RandomBreakdown()
        {
            Random rand = new Random();
            if (rand.Next(0, 100) < 10)
            {
                await Breakdown();
                Messages("<На квадрокоптере \"" + Name + "\" отключился GPS!>");
                IsBroken = true;
                WaitingForMechanic = false;
            }
        }

        protected override void CheckEvents()
        {
            if (!IsMoving)
            {
                MovingByCoordinateX = StartCoordinateX;
                MovingByCoordinateY = StartCoordinateY;
            }
        }

        public async Task WaitingForRepair()
        {
            do
            {
                await Task.Delay(100);
            } while (IsBroken);
            StartOfFlight();
            await WaitQuadrocopterUp();
        }

        public async Task Fly()
        {
            StartOfFlight();
            await WaitQuadrocopterUp();
            Messages("<Квадрокоптер \"" + Name + "\" начал полёт!>");
            var rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                MovingByCoordinateX = rand.Next(150, 800);
                MovingByCoordinateY = rand.Next(50, (int)StartCoordinateY - 200);
                await Task.Delay(400);
                await RandomBreakdown();
                await WaitingForRepair();
            }
            EndOfFlight();
            await WaitQuadrocopterDown();
            IsWorking = false;
        }
    }
}
