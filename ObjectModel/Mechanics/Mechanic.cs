using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectsModel.Mechanics
{
    public abstract class Mechanic : MovingObject, IMechanic
    {
        private readonly List<Quadrocopter> Quadrocopters;
        private readonly object QuadrocopterLocker;
        private Quadrocopter BrokenQuadrocopter { get; set; }
        protected int SpeedOfRepair { get; set; }
        protected string TypeOfMechanic { get; set; }
        public int NumberOfRepetitions { get; set; }

        public Mechanic (double startCoordinateX, double startCoordinateY, Action<string> messages, List<Quadrocopter> quadrocopters, object quadrocopterLocker)
            : base(startCoordinateX, startCoordinateY, messages)
        {
            NumberOfRepetitions = 0;
            Quadrocopters = quadrocopters;
            QuadrocopterLocker = quadrocopterLocker;
        }

        protected override void CheckEvents()
        {
            if (!IsMoving)
            {
                lock (QuadrocopterLocker)
                {
                    BrokenQuadrocopter = Quadrocopters.FirstOrDefault(Quadrocopter => Quadrocopter.IsBroken && !Quadrocopter.WaitingForMechanic);
                    if (BrokenQuadrocopter != null)
                    {
                        BrokenQuadrocopter.WaitingForMechanic = true;
                        MovingByCoordinateX = BrokenQuadrocopter.CoordinateX + 10;
                        MovingByCoordinateY = BrokenQuadrocopter.CoordinateY + 40;
                        IsMoving = true;
                        MoveTask = Repair;
                        Messages("<" + TypeOfMechanic + " \"" + Name + "\" начал подготовку к починке квадрокоптера \"" + BrokenQuadrocopter.Name + "\">");
                    }
                }
            }
        }

        protected async Task Repair()
        {
            if (EndOfWork())
            {
                Messages("<" + TypeOfMechanic + " \"" + Name + "\" производит ремонт квадрокоптера \"" + BrokenQuadrocopter.Name + "\">");
                NumberOfRepetitions++;
                await Task.Delay(SpeedOfRepair);
                BrokenQuadrocopter.IsBroken = false;
                BrokenQuadrocopter.IsMoving = true;
                Messages("<Квадрокоптер \"" + BrokenQuadrocopter.Name + "\" был починен!>");
                Messages("<" + TypeOfMechanic + " \"" + Name + "\" починил " + NumberOfRepetitions + " квадрокоптера!>");
                MoveTask = null;
                IsMoving = false;
                MovingByCoordinateX = StartCoordinateX;
                MovingByCoordinateY = StartCoordinateY;
            }
        }
    }
}
