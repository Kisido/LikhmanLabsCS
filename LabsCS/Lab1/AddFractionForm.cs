using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class AddFractionForm : Form
    {
        public AddFractionForm()
        {
            InitializeComponent();
        }

        private void ChangeButtonState() => ConfirmButton.Enabled = (int.TryParse(NumeratorTextBox.Text, out int num1) && int.TryParse(DenominatorTextBox.Text, out int num2) && num2 != 0);

        private void NumeratorTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

        private void DenominatorTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

        private void ConfirmButton_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

        private void CancelButton_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

        public string GetNumerator() => NumeratorTextBox.Text;

        public string GetDenominator() => DenominatorTextBox.Text;
    }
}
