using System.Windows.Forms;
using Lab1.Fractions;

namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Fraction fr1;
        Fraction fr2;

        private void ChangeButtonState()
        {
            AdditionButton.Enabled = ((FirstFractionLabel.Text != "") && (SecondFractionLabel.Text != ""));
            SubtractionButton.Enabled = ((FirstFractionLabel.Text != "") && (SecondFractionLabel.Text != ""));
            MultiplicationButton.Enabled = ((FirstFractionLabel.Text != "") && (SecondFractionLabel.Text != ""));
            DivisionButton.Enabled = ((FirstFractionLabel.Text != "") && (SecondFractionLabel.Text != ""));
        }

        private void FirstFractionButton_Click(object sender, System.EventArgs e)
        {
            AddFractionForm add = new AddFractionForm();
            if (add.ShowDialog() == DialogResult.OK)
            {
                fr1 = new Fraction(int.Parse(add.GetNumerator()), int.Parse(add.GetDenominator()));
                FirstFractionLabel.Text = fr1.ToString();
                ChangeButtonState();
            }
        }

        private void SecondFractionButton_Click(object sender, System.EventArgs e)
        {
            AddFractionForm add = new AddFractionForm();
            if (add.ShowDialog() == DialogResult.OK)
            {
                fr2 = new Fraction(int.Parse(add.GetNumerator()), int.Parse(add.GetDenominator()));
                SecondFractionLabel.Text = fr2.ToString();
                ChangeButtonState();
            }
        }

        private void AdditionButton_Click(object sender, System.EventArgs e)
        {
            Fraction result = Fraction.Addition(fr1, fr2);
            MessageBox.Show("Результат: " + result.ToString());
        }

        private void SubtractionButton_Click(object sender, System.EventArgs e)
        {
            Fraction result = Fraction.Subtraction(fr1, fr2);
            MessageBox.Show("Результат: " + result.ToString());
        }

        private void MultiplicationButton_Click(object sender, System.EventArgs e)
        {
            Fraction result = Fraction.Multiplication(fr1, fr2);
            MessageBox.Show("Результат: " + result.ToString());
        }

        private void DivisionButton_Click(object sender, System.EventArgs e)
        {
            Fraction result = Fraction.Division(fr1, fr2);
            MessageBox.Show("Результат: " + result.ToString());
        }
    }
}
