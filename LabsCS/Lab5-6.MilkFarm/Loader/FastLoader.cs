using System;

namespace Lab5_6.MilkFarm.Loader
{
    public class FastLoader : Loader
    {
        public FastLoader(Action<string> notification, double defaultX, double defaultY) : base(notification, defaultX, defaultY)
        {
            loadSpeed = 1000;
            loaderType = "Быстрый погрузчик";
        }
    }
}
