using Lab3.Technique;
using System.Windows.Forms;

namespace Lab3
{
    public partial class AddOrEditForm : Form
    {
        VideoPlayer videoPlayer = new VideoPlayer();
        public AddOrEditForm(ITechnique tech)
        {
            InitializeComponent();
            if (tech is VideoPlayer)
            {
                videoPlayer = tech as VideoPlayer;
                PriceTextBox.Text = videoPlayer.Price.ToString();
                ColorTextBox.Text = videoPlayer.Color;
                ModelTextBox.Text = videoPlayer.Model;
                MemoryTextBox.Text = videoPlayer.Memory.ToString();
                PictureQualityTextBox.Text = videoPlayer.PictureQuality.ToString();
                GuaranteePeriodTextBox.Text = videoPlayer.GuaranteePeriod.ToString();
            }
        }

        private void ChangeButtonState() => ConfirmButton.Enabled = (PriceTextBox.TextLength > 0 && int.TryParse(PriceTextBox.Text, out int num1) && 
                num1 > 0 && ColorTextBox.TextLength > 0 && ModelTextBox.TextLength > 0 && MemoryTextBox.TextLength > 0 && 
                int.TryParse(MemoryTextBox.Text, out int num2) && num2 > 0 && PictureQualityTextBox.TextLength > 0 &&
                int.TryParse(PictureQualityTextBox.Text, out int num3) && num3 > 0 && GuaranteePeriodTextBox.TextLength > 0 &&
                int.TryParse(GuaranteePeriodTextBox.Text, out int num4) && num4 > 0);

        private void PriceTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void ColorTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void ModelTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void MemoryTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void PictureQualityTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void GuaranteePeriodTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void ConfirmButton_Click(object sender, System.EventArgs e) => SaveInfo();

        private void CancelButton_Click(object sender, System.EventArgs e) => this.DialogResult = DialogResult.Cancel;

        private void SaveInfo()
        {
            videoPlayer.Price = int.Parse(PriceTextBox.Text);
            videoPlayer.Color = ColorTextBox.Text;
            videoPlayer.Model = ModelTextBox.Text;
            videoPlayer.Memory = int.Parse(MemoryTextBox.Text);
            videoPlayer.PictureQuality = int.Parse(PictureQualityTextBox.Text);
            videoPlayer.GuaranteePeriod = int.Parse(GuaranteePeriodTextBox.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
