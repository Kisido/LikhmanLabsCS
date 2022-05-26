using Lab2.Diamond;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FirstLvlDiamond firstDiamond = null;

        SecondLvlDiamond secondDiamond = null;

        private void InputButton_Click(object sender, EventArgs e)
        {
            AddDiamondForm add = new AddDiamondForm();
            if (add.ShowDialog() == DialogResult.OK)
            {
                if (add.GetColor() == "")
                {
                    firstDiamond = new FirstLvlDiamond(add.GetName(), int.Parse(add.GetCaratWeight()), int.Parse(add.GetCutQuality()));
                    secondDiamond = null;
                }
                else
                {
                    secondDiamond = new SecondLvlDiamond(add.GetName(), int.Parse(add.GetCaratWeight()), int.Parse(add.GetCutQuality()), add.GetColor());
                    firstDiamond = null;
                }
                DiamondTextLabel.Text = "";
            }    
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            if (firstDiamond == null && secondDiamond == null)
            {
                DiamondTextLabel.Text = "";
                MessageBox.Show("Сначала введите данные об алмазе!");
            }
            else if (secondDiamond == null)
            {
                DiamondTextLabel.Text = firstDiamond.ToString();
            }
            else if (firstDiamond == null)
            {
                DiamondTextLabel.Text = secondDiamond.ToString();
            }
        }

        private void QualityButton_Click(object sender, EventArgs e)
        {
            if (firstDiamond == null && secondDiamond == null)
            {
                DiamondTextLabel.Text = "";
                MessageBox.Show("Сначала введите данные об алмазе!");
            }
            else if (secondDiamond == null)
            {
                MessageBox.Show("Качество алмаза первого класса: " + firstDiamond.Quality());
            }
            else if (firstDiamond == null)
            {
                MessageBox.Show("Качество алмаза второго класса: " + secondDiamond.Quality());
            }
        }
    }
}
