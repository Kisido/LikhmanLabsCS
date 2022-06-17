using Lab5_6.MilkFarm;
using Lab5_6.MilkFarm.Loader;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using loader = Lab5_6.MilkFarm.Loader.Loader;

namespace Lab5_6
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
        List<Object> viewObjects;
        List<Mechanic> mechanics;
        object viewObjectLocker;
        List<ViewModel> viewModels;
        object viewModelsLocker;
        object mechanicLocker;
        object loaderLocker;
        List<loader> loaders;
        List<Warehouse> warehouses;
        List<string> notifications;

        ObjectDrawer drawer;

        private void InititalizeForm()
        {
            countMechanics = 0;
            viewObjects = new List<Object>();
            viewObjectLocker = new object();
            viewModels = new List<ViewModel>();
            viewModelsLocker = new object();
            mechanicLocker = new object();
            loaderLocker = new object();
            mechanics = new List<Mechanic>();
            loaders = new List<loader>();
            warehouses = new List<Warehouse>();
            notifications = new List<string>();
            drawer = new ObjectDrawer(PictureBox, Properties.Resources.Background, viewObjects, viewObjectLocker, viewModels, viewModelsLocker);
            drawer.Start();
        }

        void Notification(string message)
        {
            TextBox.Invoke((MethodInvoker)delegate
            {
                notifications.Add(message);
                TextBox.SelectedText += message + "\r\n\r\n";
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

            y += warehouses.Count() * 100;

            warehouses.Add(new Warehouse(Notification, loaders, loaderLocker, x, y));

            lock (viewObjectLocker)
            {
                Image img = new Bitmap(Properties.Resources.Warehouse, 100, 100);
                viewObjects.Add(new Object(img, x, y));
            }

            warehouses[warehouses.Count() - 1].Name = InputName();
            Task.Run(warehouses[warehouses.Count() - 1].Start);

            if (warehouses.Count() >= MAX_WAREHOUSES)
            {
                AddWarehouseButton.Enabled = false;
            }
        }

        private void AddMechanicButton_Click(object sender, System.EventArgs e)
        {
            float x = 800, y = 50;
            y += countMechanics * 100;
            countMechanics++;

            Mechanic newMechanic = new Mechanic(Notification, x, y, loaders, loaderLocker)
            {
                Name = InputName()
            };

            lock (mechanicLocker)
            {
                mechanics.Add(newMechanic);
            }

            lock (viewModels)
            {
                Image img = new Bitmap(Properties.Resources.Mechanic, 100, 100);
                viewModels.Add(new ViewModel(newMechanic, img, x, y));
            }

            Task.Run(newMechanic.Start);

            if (countMechanics >= MAX_MECHANICS)
            {
                AddMechanicButton.Enabled = false;
            }
        }

        private void AddLoader(loader lo)
        {
            float x = 400, y = 50;
            y += loaders.Count * 100;
            lo.Name = InputName();
            loaders.Add(lo);

            lock (viewModelsLocker)
            {
                Image img = new Bitmap(Properties.Resources.Loader, 100, 100);
                viewModels.Add(new ViewModel(lo, img, x, y));
            }

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
            SlowLoader lo = Activator.CreateInstance(typeof(SlowLoader), new object[]
            { (Action<string>)Notification, 400, 50 + loaders.Count * 100 }) as SlowLoader;
            AddLoader(lo);
        }

        private void AddMediumLoaderButton_Click(object sender, EventArgs e)
        {
            MediumLoader lo = Activator.CreateInstance(typeof(MediumLoader), new object[]
            { (Action<string>)Notification, 400, 50 + loaders.Count * 100 }) as MediumLoader;
            AddLoader(lo);
        }

        private void AddFastLoaderButton_Click(object sender, EventArgs e)
        {   
            FastLoader lo = Activator.CreateInstance(typeof(FastLoader), new object[]
            { (Action<string>)Notification, 400, 50 + loaders.Count * 100 }) as FastLoader;
            AddLoader(lo);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            drawer.Stop();

            foreach (loader lo in loaders)
            {
                lo.IsCanceled = true;
            }

            foreach (ViewModel mo in viewModels)
            {
                if (mo is ViewModel)
                {
                    mo.Model.IsCanceled = true;
                }
            }
        }

        private void TextBox_MouseMove(object sender, MouseEventArgs e) => TextBox.SelectionLength = 0;

        private void TextBox_Click(object sender, EventArgs e) => TextBox.SelectionLength = 0;
    }
}
