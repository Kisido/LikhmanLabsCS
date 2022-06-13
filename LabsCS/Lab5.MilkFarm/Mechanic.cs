using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loader = Lab5.MilkFarm.Loader.Loader;

namespace Lab5.MilkFarm
{
    public class Mechanic : MovingObject
    {
        public Mechanic(Action<string> notification, double defaultX, double defaultY) : base(notification, defaultX, defaultY) { }

        public Mechanic(Action<string> notification, double defaultX, double defaultY, List<loader> lo, object loLo) : base(notification, defaultX, defaultY)
        {
            loaders = lo;
            loaderLocker = loLo;
        }

        private readonly List<loader> loaders;
        private readonly object loaderLocker;

        loader brokeLoader;

        void Repair()
        {
            if (HasCome())
            {
                Notification("Механик " + Name + " чинит погрузчик " + brokeLoader.Name);
                Task.Delay(3000);
                brokeLoader.IsBroke = false;
                brokeLoader.IsLocked = false;
                Notification("Погрузчик " + brokeLoader.Name + " починен");
                Notification("Механик " + Name + " починил погрузчик " + brokeLoader.Name);
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
                brokeLoader = loaders.FirstOrDefault(lo => lo.IsBroke && !lo.IsWaitingMech);
                if (brokeLoader != null)
                {
                    brokeLoader.IsWaitingMech = true;
                    MoveToX = brokeLoader.X;
                    MoveToY = brokeLoader.Y;
                    IsLocked = true;
                    CurrentTask = Repair;
                    Notification("Механик " + Name + " пошёл чинить погрузчик " + brokeLoader.Name);
                }
            }
        }
    }
}
