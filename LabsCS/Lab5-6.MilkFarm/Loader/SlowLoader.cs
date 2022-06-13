using System;
using System.Collections.Generic;

namespace Lab5_6.MilkFarm.Loader
{
    public class SlowLoader : Loader
    {
        public SlowLoader(Action<string> notification, double defaultX, double defaultY, List<Warehouse> warehouses, object warehouseLocker) : base(notification, defaultX, defaultY, warehouses, warehouseLocker)
        {
            loadSpeed = 5000;
            loaderType = "Медленный погрузчик";
        }
    }
}
