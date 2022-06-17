using System;

namespace Lab5_6.MilkFarm
{
    public abstract class Model
    {
        public double X { get; internal set; }

        public double Y { get; internal set; }

        public bool IsLocked { get; internal set; }

        public bool IsCanceled { get; set; }

        public abstract void Start();

        public Action<string> Notification;

        public Model(Action<string> notification) => Notification = notification;
    }
}
