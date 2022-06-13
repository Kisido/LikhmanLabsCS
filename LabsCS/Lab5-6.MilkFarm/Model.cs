using System;

namespace Lab5_6.MilkFarm
{
    public abstract class Model
    {
        public double X { get; set; }

        public double Y { get; set; }

        public bool IsLocked { get; set; }

        public bool IsCanceled { get; set; }

        public abstract void Start();

        public Action<string> Notification;

        public Model(Action<string> notification) => Notification = notification;

        public Model(Action<string> notification, double x, double y)
        {
            Notification = notification;
            X = x;
            Y = y;
        }
    }
}
