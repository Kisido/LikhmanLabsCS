using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using loader = Lab5.MilkFarm.Loader.Loader;

namespace Lab5.MilkFarm
{
    public class Warehouse : Model
    {
        private readonly List<loader> loaders;
        private readonly object loadersLocker;
        loader currentLoader;

        public Warehouse(Action<string> notification, List<loader> loaders, object loadersLocker, double x, double y) : base(notification)
        {
            currentLoader = null;
            this.loaders = loaders;
            this.loadersLocker = loadersLocker;
            X = x;
            Y = y;
        }

        public string Name { get; set; }

        public bool IsFull { get; set; }

        public bool IsWaitingLoader { get; set; }

        public void WorkWarehouse()
        {
            Notification("Происходит заполнение товаров на складе " + Name);

            while (!IsFull)
            {
                Task.Delay(1500).Wait();
                RandomFull();
            }
        }

        void WaitLoader()
        {
            bool isCame = false;

            while (!isCame)
            {
                Task.Delay(100).Wait();

                lock (loadersLocker)
                {
                    isCame = currentLoader.HasCome();
                }
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

        public void WaitRepair()
        {
            do
            {
                Task.Delay(100).Wait();
            } while (currentLoader.IsBroke);
        }

        bool StartLoad()
        {
            bool isLoad = false;
            lock (loadersLocker)
            {
                for (int i = 0; i < loaders.Count && !isLoad; i++)
                {
                    if (!loaders[i].IsLocked)
                    {
                        currentLoader = loaders[i];
                        currentLoader.MoveToX = X;
                        currentLoader.MoveToY = Y;
                        currentLoader.IsLocked = true;
                        Notification(currentLoader.loaderType + " " + currentLoader.Name + " поехал загружать товар из склада " + Name);
                        isLoad = true;
                    }
                }
            }
            return isLoad;
        }

        public void EndLoad()
        {
            if (currentLoader.HasCome())
            {
                Notification(currentLoader.loaderType + " " + currentLoader.Name + " загружает товар со склада " + Name);
                Task.Delay(currentLoader.loadSpeed * 2).Wait();
                IsFull = false;
                IsLocked = false;
                Notification(currentLoader.loaderType + " " + Name + " загрузил товар со склада " + Name);
                Notification("Склад " + Name + " пуст");
                currentLoader.CurrentTask = null;
            }

            if (currentLoader.RandomBroke())
            {
                WaitRepair();
            }
            else
            {
                currentLoader.IsLocked = false;
            }
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                Notification("Начало работы склада " + Name);
                Task.Delay(1000).Wait();
                WorkWarehouse();
                if (!StartLoad())
                {
                    Notification("Погрузчики не приехали на склад, товар отгружен другим способом");
                }
                else
                {
                    WaitLoader();
                    EndLoad();
                }
                Task.Delay(6000).Wait();
            }
        }
    }
}
