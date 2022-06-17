using System;
using System.Collections.Generic;

namespace Lab5_6.MilkFarm.Loader
{
    public class SlowLoader : Loader
    {
        public SlowLoader(Action<string> notification, double defaultX, double defaultY) : base(notification, defaultX, defaultY)
        {
            loadSpeed = 5000;
            loaderType = "Медленный погрузчик";
        }
    }
}
