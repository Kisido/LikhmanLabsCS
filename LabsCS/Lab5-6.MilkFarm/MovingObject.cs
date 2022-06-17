using System;
using System.Threading.Tasks;

namespace Lab5_6.MilkFarm
{
    public abstract class MovingObject : Model
    {
        const double MAX_SPEED = 3;

        public Action CurrentTask;

        public double defaultX, defaultY;

        public double MoveToX { get; internal set; }
        
        public double MoveToY { get; internal set; }

        public string Name { get; set; }

        public MovingObject(Action<string> notification, double defaultX, double defaultY) : base(notification)
        {
            this.defaultX = defaultX;
            this.defaultY = defaultY;
            X = defaultX;
            Y = defaultY;
            MoveToX = defaultX;
            MoveToY = defaultY;
            CurrentTask = null;
        }

        protected abstract void CheckEvents();

        public bool HasCome() => Math.Abs(X - MoveToX) < 5 && Math.Abs(Y - MoveToY) < 5;

        public void Move()
        {
            if (HasCome()) return;

            if (X - MoveToX != 0)
            {
                X += MAX_SPEED * Math.Sign(MoveToX - X);
                Y += MAX_SPEED * (MoveToY - Y) / Math.Abs(MoveToX - X);
            }
            else
            {
                X += MAX_SPEED * (MoveToX - X) / Math.Abs(MoveToY - Y);
                Y += MAX_SPEED * Math.Sign(MoveToY - Y);
            }
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                CheckEvents();
                Move();
                CurrentTask?.Invoke();
                Task.Delay(30).Wait();
            }
        }
    }
}
