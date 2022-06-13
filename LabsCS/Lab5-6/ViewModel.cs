using Lab5_6.MilkFarm;
using System.Drawing;

namespace Lab5_6
{
    class ViewModel : Object
    {
        public Model Model { get; }

        public override double X { get; set; }

        public override double Y { get; set; }

        public ViewModel(Model model, Image image) : base(image) => Model = model;

        public ViewModel(Model model, Image image, float x, float y) : base(image, x, y) => Model = model;
    }
}
