using Lab5.MilkFarm;
using Lab5.MilkFarm.Loader;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using loader = Lab5.MilkFarm.Loader.Loader;

namespace Lab5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InititalizeForm();
        }

        const int MAX_LOADERS = 5;
        const int MAX_MECHANICS = 5;
        const int MAX_WAREHOUSES = 5;
        int countMechanics;
        object warehouseLocker;
        object loaderLocker;
        List<loader> loaders;
        List<Warehouse> warehouses;
        List<string> notifications;

        private void InititalizeForm()
        {
            countMechanics = 0;
            warehouseLocker = new object();
            loaderLocker = new object();
            loaders = new List<loader>();
            warehouses = new List<Warehouse>();
            notifications = new List<string>();
        }
        void Notification(string message)
        {
            TextBox.Invoke((MethodInvoker)delegate
            {
                notifications.Add(message);
                TextBox.Text += message + "\r\n\r\n";
            });
        }

        private string InputName()
        {
            AddForm add = new AddForm();

            add.ShowDialog();

            return add.GetName();
        }

        private void AddWarehouseButton_Click(object sender, System.EventArgs e)
        {
            float x = 50, y = 50;
            y += warehouses.Count * 100;
            warehouses.Add(new Warehouse(Notification, x, y));
            warehouses[warehouses.Count - 1].Name = InputName();
            Task.Run(warehouses[warehouses.Count - 1].Start);
            if (warehouses.Count >= MAX_WAREHOUSES)
            {
                AddWarehouseButton.Enabled = false;
            }
        }

        private void AddMechanicButton_Click(object sender, System.EventArgs e)
        {
            float x = 800, y = 50;
            y += countMechanics * 100;
            countMechanics++;
            Mechanic newMechanic = new Mechanic(Notification, x, y, loaders, loaderLocker);
            newMechanic.Name = InputName();
            Task.Run(newMechanic.Start);
            if (countMechanics >= MAX_MECHANICS)
            {
                AddMechanicButton.Enabled = false;
            }
        }

        private void AddLoader(loader lo)
        {
            AddMechanicButton.Enabled = true;
            lo.Name = InputName();
            loaders.Add(lo);
            if (loaders.Count >= MAX_LOADERS)
            {
                AddLoaderButton.Enabled = false;
                AddFastLoaderButton.Enabled = false;
                AddMediumLoaderButton.Enabled = false;
                AddSlowLoaderButton.Enabled = false;
            }
            Task.Run(lo.Start);
        }

        private void AddSlowLoaderButton_Click(object sender, System.EventArgs e)
        {
            FastLoader lo = Activator.CreateInstance(typeof(FastLoader), new object[]
            { (Action<string>)Notification, 400, 50 + loaders.Count * 100, warehouses, warehouseLocker }) as FastLoader;
            AddLoader(lo);
        }

        private void AddMediumLoaderButton_Click(object sender, System.EventArgs e)
        {
            MediumLoader lo = Activator.CreateInstance(typeof(MediumLoader), new object[]
            { (Action<string>)Notification, 400, 50 + loaders.Count * 100, warehouses, warehouseLocker }) as MediumLoader;
            AddLoader(lo);
        }

        private void AddFastLoaderButton_Click(object sender, System.EventArgs e)
        {
            SlowLoader lo = Activator.CreateInstance(typeof(SlowLoader), new object[]
            { (Action<string>)Notification, 400, 50 + loaders.Count * 100, warehouses, warehouseLocker }) as SlowLoader;
            AddLoader(lo);
        }
    }
}
