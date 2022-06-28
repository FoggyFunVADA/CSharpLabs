using System;

namespace ObjectsModel
{
    public abstract class Object
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public bool IsMoving { get; set; }
        public bool IsWorking { get; set; }

        public Action<string> Messages;
        public abstract void StartOfWork();

        public Object(Action<string> messages)
        {
            Messages = messages;
        }
    }
}
