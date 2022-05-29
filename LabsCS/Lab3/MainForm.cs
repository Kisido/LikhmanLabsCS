using Lab3.Technique;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GenerateMoneyCount();
        }

        private void GenerateMoneyCount()
        {
            Random random = new Random();
            MoneyLabel.Text = random.Next(1000, 9999).ToString();
        }

        public List<ITechnique> techniques = new List<ITechnique>();

        private void VideoPlayerListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (VideoPlayerListBox.SelectedIndex != -1)
            {
                int current = VideoPlayerListBox.SelectedIndex;
                AddOrEditForm edit = new AddOrEditForm(techniques[current]);
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    VideoPlayerListBox.Items.RemoveAt(current);
                    VideoPlayerListBox.Items.Insert(current, techniques[current]);
                }
            }
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            ITechnique technique = new VideoPlayer();
            AddOrEditForm add = new AddOrEditForm(technique);
            if (add.ShowDialog() == DialogResult.OK)
            {
                techniques.Add(technique);
                VideoPlayerListBox.Items.Add(technique);
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (VideoPlayerListBox.SelectedIndex != -1)
            {
                int current = VideoPlayerListBox.SelectedIndex;
                techniques.RemoveAt(current);
                VideoPlayerListBox.Items.RemoveAt(current);
            }
        }

        private void AskInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VideoPlayerListBox.SelectedIndex != -1)
            {
                VideoPlayer player = techniques[VideoPlayerListBox.SelectedIndex] as VideoPlayer;
                MessageBox.Show(player.AskInformationFromConsultant());
            }
        }

        private void WatchVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VideoPlayerListBox.SelectedIndex != -1)
            {
                VideoPlayer player = techniques[VideoPlayerListBox.SelectedIndex] as VideoPlayer;
                MessageBox.Show(player.TryWatchVideo());
            }
        }

        private void ChangeVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VideoPlayerListBox.SelectedIndex != -1)
            {
                VideoPlayer player = techniques[VideoPlayerListBox.SelectedIndex] as VideoPlayer;
                MessageBox.Show(player.ChangeVolume());
            }
        }

        private void RateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VideoPlayerListBox.SelectedIndex != -1)
            {
                VideoPlayer player = techniques[VideoPlayerListBox.SelectedIndex] as VideoPlayer;
                MessageBox.Show(player.Rate());
            }
        }

        private void BuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VideoPlayerListBox.SelectedIndex != -1)
            {
                VideoPlayer player = techniques[VideoPlayerListBox.SelectedIndex] as VideoPlayer;
                int oldMoney = int.Parse(MoneyLabel.Text);
                int money = oldMoney;
                MessageBox.Show(player.Buy(ref money));
                if (money != oldMoney)
                {
                    MoneyLabel.Text = money.ToString();
                }
            }
        }
    }
}
