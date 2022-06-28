using System;
using System.Collections.Generic;

namespace ObjectsModel.Mechanics
{
    public class ExperiencedMechanic : Mechanic
    {
        public ExperiencedMechanic(double startCoordinateX, double startCoordinateY, Action<string> messages, List<Quadrocopter> quadrocopters, object quadrocopterLocker)
            : base(startCoordinateX, startCoordinateY, messages, quadrocopters, quadrocopterLocker)
        {
            SpeedOfRepair = 4000;
            TypeOfMechanic = "Опытный механик";
        }
    }
}
