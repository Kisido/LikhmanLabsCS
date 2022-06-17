using System;
using System.Windows.Forms;

namespace Lab5_6
{
    public partial class AddForm : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle |= CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public AddForm()
        {
            InitializeComponent();
        }

        private bool ChangeState() => ConfirmButton.Enabled = NameTextBox.TextLength > 0;

        private void ConfirmButton_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

        private void NameTextBox_TextChanged(object sender, EventArgs e) => ChangeState();

        public string GetName() => NameTextBox.Text;
    }
}
