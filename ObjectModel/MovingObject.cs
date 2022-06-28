using System;
using System.Threading.Tasks;

namespace ObjectsModel
{
    public abstract class MovingObject : Object
    {
        protected const int Speed = 7;
        public Func<Task> MoveTask { get; set; }
        public double StartCoordinateX { get; set; }
        public double StartCoordinateY { get; set; }
        public double MovingByCoordinateX { get; set; }
        public double MovingByCoordinateY { get; set; }
        public string Name { get; set; }

        public MovingObject(double startCoordinateX, double startCoordinateY, Action<string> messages) : base(messages)
        {
            StartCoordinateX = startCoordinateX;
            StartCoordinateY = startCoordinateY;
            CoordinateX = startCoordinateX;
            CoordinateY = startCoordinateY;
            MovingByCoordinateX = startCoordinateX;
            MovingByCoordinateY = startCoordinateY;
            MoveTask = null;
        }

        protected abstract void CheckEvents();

        public async override void StartOfWork()
        {
            while (!IsWorking)
            {
                CheckEvents();
                Moving();
                if (MoveTask != null)
                    await MoveTask();
                await Task.Delay(30);
            }
        }

        public bool EndOfWork()
        {
            return Math.Abs(CoordinateX - MovingByCoordinateX) < 5 && Math.Abs(CoordinateY - MovingByCoordinateY) < 5;
        }

        public void Moving()
        {
            if (!EndOfWork())
            {
                if (Math.Abs(CoordinateX - MovingByCoordinateX) > 2)
                {
                    CoordinateY += (3 * (MovingByCoordinateY - CoordinateY) / Math.Abs(CoordinateX - MovingByCoordinateX)) % Speed;
                    CoordinateX += (3 * Math.Sign(MovingByCoordinateX - CoordinateX)) % Speed;
                }
                else
                {
                    CoordinateX += (3 * (MovingByCoordinateX - CoordinateX) / Math.Abs(CoordinateY - MovingByCoordinateY)) % Speed;
                    CoordinateY += (3 * Math.Sign(MovingByCoordinateY - CoordinateY)) % Speed;
                }
            }
        }
    }
}
