using System.Drawing;

namespace ObjectsView
{
    public class CoordinatesForImage
    {
        public Image Image { get; set; }
        public virtual double CoordinateX { get; set; }
        public virtual double CoordinateY { get; set; }

        public CoordinatesForImage (Image image)
        {
            Image = image;
        }

        public CoordinatesForImage (Image image, double coordinateX, double coordinateY)
        {
            Image = image;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }
}
