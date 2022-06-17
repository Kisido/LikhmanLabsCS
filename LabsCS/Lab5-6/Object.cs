using System.Drawing;

namespace Lab5_6
{
    class Object
    {
        public virtual double X { get; set; }

        public virtual double Y { get; set; }

        public Image Image { get; set; }

        public Object(Image image, double x, double y)
        {
            Image = image;
            X = x;
            Y = y;
        }
    }
}
