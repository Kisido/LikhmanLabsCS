using System;
using System.Threading.Tasks;

namespace Lab5_6.MilkFarm
{
    public class Warehouse : Model
    {
        public Warehouse(Action<string> notification, string name) : base(notification) => Name = name;

        public Warehouse(Action<string> notification, double defaultX, double defaultY) : base(notification, defaultX, defaultY) { }

        public string Name { get; set; }

        public bool IsFull { get; set; }

        public bool IsWaitingLoader { get; set; }

        public void WorkWarehouse()
        {
            Notification("Происходит заполнение товаров на складе " + Name);
            while (!IsFull)
            {
                RandomFull();
                Task.Delay(1500).Wait();
            }
        }

        public void RandomFull()
        {
            Random random = new Random();
            if (random.Next(0, 200) > 170)
            {
                Notification("Склад " + Name + " заполнен");
                IsFull = true;
                IsWaitingLoader = false;
            }
        }

        public void WaitLoad()
        {
            do
            {
                Task.Delay(1000).Wait();
            } while (IsFull);
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                Notification("Начало работы склада " + Name);
                Task.Delay(1000).Wait();
                WorkWarehouse();
                WaitLoad();
                Task.Delay(6000).Wait();
            }
        }
    }
}
