using System;
using System.Collections.Generic;

namespace Lab5.MilkFarm.Loader
{
    public class FastLoader : Loader
    {
        public FastLoader(Action<string> notification, double defaultX, double defaultY, List<Warehouse> warehouses, object warehouseLocker) : base(notification, defaultX, defaultY, warehouses, warehouseLocker)
        {
            loadSpeed = 1000;
            loaderType = "Быстрый погрузчик";
        }
    }
}
