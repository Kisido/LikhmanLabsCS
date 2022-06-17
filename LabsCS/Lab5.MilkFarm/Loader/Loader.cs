using System;

namespace Lab5.MilkFarm.Loader
{
    public abstract class Loader : MovingObject, ILoader
    {
        public int NumberOfCompletedTransportations { get; set; }
        public int loadSpeed;
        public string loaderType;

        public bool IsBroke { get; internal set; }

        public bool IsWaitingMech { get; internal set; }

        public Loader(Action<string> notification, double defaultX, double defaultY) : base(notification, defaultX, defaultY)
        {
            NumberOfCompletedTransportations = 0;
        }

        public bool RandomBroke()
        {
            Random random = new Random();
            if (random.Next(0, 200) < 77)
            {
                Notification("Погрузчик " + Name + " сломался");
                IsBroke = true;
                IsWaitingMech = false;
            }
            return IsBroke;
        }

        protected override void CheckEvents()
        {
            if (!IsLocked)
            {
                MoveToX = defaultX;
                MoveToY = defaultY;
            }
        }
    }
}
