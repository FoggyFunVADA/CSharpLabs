using System;
using System.Collections.Generic;

namespace ObjectsModel.Mechanics
{
    public class TraineeMechanic : Mechanic
    {
        public TraineeMechanic (double startCoordinateX, double startCoordinateY, Action<string> messages, List<Quadrocopter> quadrocopters, object quadrocopterLocker)
            : base (startCoordinateX, startCoordinateY, messages, quadrocopters, quadrocopterLocker)
        {
            SpeedOfRepair = 5500;
            TypeOfMechanic = "Механик-стажёр";
        }
    }
}
