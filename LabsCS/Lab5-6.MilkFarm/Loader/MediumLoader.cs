using System;
using System.Collections.Generic;

namespace Lab5_6.MilkFarm.Loader
{
    public class MediumLoader : Loader
    {
        public MediumLoader(Action<string> notification, double defaultX, double defaultY, List<Warehouse> warehouses, object warehouseLocker) : base(notification, defaultX, defaultY, warehouses, warehouseLocker)
        {
            loadSpeed = 3000;
            loaderType = "Средний погрузчик";
        }
    }
}
