using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loader = Lab5.MilkFarm.Loader.Loader;

namespace Lab5.MilkFarm
{
    public class Mechanic : MovingObject
    {
        public Mechanic(Action<string> notification, double defaultX, double defaultY, List<loader> lo, object loLo) : base(notification, defaultX, defaultY)
        {
            loaders = lo;
            loaderLocker = loLo;
        }

        private readonly List<loader> loaders;
        private readonly object loaderLocker;
        loader brokenLoader;

        void Repair()
        {
            if (HasCome())
            {
                Notification("Механик " + Name + " чинит погрузчик " + brokenLoader.Name);
                Task.Delay(3000).Wait();
                brokenLoader.IsBroke = false;
                brokenLoader.IsLocked = false;
                Notification("Погрузчик " + brokenLoader.Name + " починен");
                Notification("Механик " + Name + " починил погрузчик " + brokenLoader.Name);
                CurrentTask = null;
                IsLocked = false;
                MoveToX = defaultX;
                MoveToY = defaultY;
            }
        }

        protected override void CheckEvents()
        {
            if (IsLocked) return;

            lock (loaderLocker)
            {
                brokenLoader = loaders.FirstOrDefault(lo => lo.IsBroke && !lo.IsWaitingMech);
                if (brokenLoader != null)
                {
                    brokenLoader.IsWaitingMech = true;
                    MoveToX = brokenLoader.X;
                    MoveToY = brokenLoader.Y;
                    IsLocked = true;
                    CurrentTask = Repair;
                    Notification("Механик " + Name + " пошёл чинить погрузчик " + brokenLoader.Name);
                }
            }
        }
    }
}
