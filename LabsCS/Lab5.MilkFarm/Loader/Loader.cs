using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.MilkFarm.Loader
{
    public abstract class Loader : MovingObject, ILoader
    {
        public int NumberOfCompletedTransportations { get; set; }
        protected int loadSpeed;
        protected string loaderType;

        Warehouse fullWarehouse;
        private readonly List<Warehouse> warehouses;
        private readonly object warehouseLocker;

        public bool IsBroke { get; set; }

        public bool IsWaitingMech { get; set; }

        public Loader(Action<string> notification, double defaultX, double defaultY, List<Warehouse> warehouses, object warehouseLocker) : base(notification, defaultX, defaultY)
        {
            NumberOfCompletedTransportations = 0;
            this.warehouses = warehouses;
            this.warehouseLocker = warehouseLocker;
        }

        public void RandomBroke()
        {
            Random random = new Random();
            if (random.Next(0, 200) < 5)
            {
                Notification("Погрузчик " + Name + " сломался");
                IsBroke = true;
                IsWaitingMech = false;
            }
        }

        private void Load()
        {
            if (HasCome())
            {
                Notification(loaderType + " " + Name + " загружает товар со склада " + fullWarehouse.Name);
                Task.Delay(loadSpeed);
                fullWarehouse.IsFull = false;
                fullWarehouse.IsLocked = false;
                Notification(loaderType + " " + Name + " загрузил товар со склада " + fullWarehouse.Name);
                Notification("Склад " + fullWarehouse.Name + " пуст");
                CurrentTask = null;
                IsLocked = false;
                MoveToX = defaultX;
                MoveToY = defaultY;
            }
        }

        protected override void CheckEvents()
        {
            if (IsLocked) return;

            lock (warehouseLocker)
            {
                fullWarehouse = warehouses.FirstOrDefault(warehouse => warehouse.IsFull && !warehouse.IsWaitingLoader);

                if (fullWarehouse != null)
                {
                    fullWarehouse.IsWaitingLoader = true;
                    MoveToX = fullWarehouse.X;
                    MoveToY = fullWarehouse.Y;
                    IsLocked = true;
                    CurrentTask = Load;
                    Notification(loaderType + " " + Name + " поехал загружать товар из склада " + fullWarehouse.Name);
                }
            }
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                RandomBroke();
                CheckEvents();
                Move();
                CurrentTask?.Invoke();
                Task.Delay(300).Wait();
            }
        }
    }
}
