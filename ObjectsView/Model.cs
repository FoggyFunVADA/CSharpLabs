using System.Drawing;
using ObjectsModel;

namespace ObjectsView
{
    public class Model : CoordinatesForImage
    {
        public Object Element { get; }
        public override double CoordinateX { get => Element.CoordinateX; }
        public override double CoordinateY { get => Element.CoordinateY; }

        public Model(Object model, Image image) : base(image)
        {
            Element = model;
        }
    }
}
