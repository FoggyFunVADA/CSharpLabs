﻿using System;
using System.Collections.Generic;

namespace ObjectsModel.Mechanics
{
    public class ProfessionalMechanic : Mechanic
    {
        public ProfessionalMechanic (double startCoordinateX, double startCoordinateY, Action<string> messages, List<Quadrocopter> quadrocopters, object quadrocopterLocker)
            : base (startCoordinateX, startCoordinateY, messages, quadrocopters, quadrocopterLocker)
        {
            SpeedOfRepair = 2000;
            TypeOfMechanic = "Механик профессионал";
        }
    }
}
