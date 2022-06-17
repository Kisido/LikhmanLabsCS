using System;

namespace Lab5.MilkFarm.Loader
{
    public class MediumLoader : Loader
    {
        public MediumLoader(Action<string> notification, double defaultX, double defaultY) : base(notification, defaultX, defaultY)
        {
            loadSpeed = 3000;
            loaderType = "Средний погрузчик";
        }
    }
}
