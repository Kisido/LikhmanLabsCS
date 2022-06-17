using Lab5_6.MilkFarm;
using System.Drawing;

namespace Lab5_6
{
    class ViewModel : Object
    {
        public Model Model { get; }

        public override double X { get => Model.X; }

        public override double Y { get => Model.Y; }

        public ViewModel(Model model, Image image, float x, float y) : base(image, x, y) => Model = model;
    }
}
