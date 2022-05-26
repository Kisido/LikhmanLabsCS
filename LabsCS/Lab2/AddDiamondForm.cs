using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class AddDiamondForm : Form
    {
        public AddDiamondForm()
        {
            InitializeComponent();
        }

        private void ChangeButtonState()
        {
            if (FirstClassRadioButton.Checked)
            {
                ConfirmButton.Enabled = NameTextBox.TextLength != 0 && int.TryParse(CaratWeightTextBox.Text, out int num1)
                    && int.TryParse(CutQualityTextBox.Text, out int num2);
            }
            else
            {
                ConfirmButton.Enabled = NameTextBox.TextLength != 0 && int.TryParse(CaratWeightTextBox.Text, out int num1)
                    && int.TryParse(CutQualityTextBox.Text, out int num2) && ColorTextBox.TextLength != 0;
            }
        }

        private void ChangeColorState(bool state)
        {
            ColorLabel.Enabled = state; 
            ColorTextBox.Enabled = state;
            if (!state) ColorTextBox.Text = "";
            ChangeButtonState();
        }

        private void ConfirmButton_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

        private void CancelButton_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

        private void FirstClassRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeColorState(false);

        private void SecondClassRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeColorState(true);

        private void NameTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

        private void CaratWeightTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

        private void CutQualityTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

        private void ColorTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

        public string GetName() => NameTextBox.Text;

        public string GetCaratWeight() => CaratWeightTextBox.Text;

        public string GetCutQuality() => CutQualityTextBox.Text;

        public string GetColor() => ColorTextBox.Text;
    }
}
