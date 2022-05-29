
namespace Lab3
{
    partial class AddOrEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.PictureQualityLabel = new System.Windows.Forms.Label();
            this.PictureQualityTextBox = new System.Windows.Forms.TextBox();
            this.GuaranteePeriodLabel = new System.Windows.Forms.Label();
            this.GuaranteePeriodTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(13, 13);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(447, 23);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Введите цену (целое положительное):";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(16, 40);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(444, 22);
            this.PriceTextBox.TabIndex = 1;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.Location = new System.Drawing.Point(13, 76);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(447, 23);
            this.ColorLabel.TabIndex = 2;
            this.ColorLabel.Text = "Введите цвет:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(16, 102);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(444, 22);
            this.ColorTextBox.TabIndex = 3;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(13, 137);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(447, 23);
            this.ModelLabel.TabIndex = 4;
            this.ModelLabel.Text = "Введите модель:";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(16, 163);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(444, 22);
            this.ModelTextBox.TabIndex = 5;
            this.ModelTextBox.TextChanged += new System.EventHandler(this.ModelTextBox_TextChanged);
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Location = new System.Drawing.Point(13, 198);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(447, 23);
            this.MemoryLabel.TabIndex = 6;
            this.MemoryLabel.Text = "Введите объём памяти (целое положительное):";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Location = new System.Drawing.Point(16, 224);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(444, 22);
            this.MemoryTextBox.TabIndex = 7;
            this.MemoryTextBox.TextChanged += new System.EventHandler(this.MemoryTextBox_TextChanged);
            // 
            // PictureQualityLabel
            // 
            this.PictureQualityLabel.Location = new System.Drawing.Point(13, 258);
            this.PictureQualityLabel.Name = "PictureQualityLabel";
            this.PictureQualityLabel.Size = new System.Drawing.Size(447, 23);
            this.PictureQualityLabel.TabIndex = 8;
            this.PictureQualityLabel.Text = "Введите качество изображения (целое положительное):";
            // 
            // PictureQualityTextBox
            // 
            this.PictureQualityTextBox.Location = new System.Drawing.Point(16, 284);
            this.PictureQualityTextBox.Name = "PictureQualityTextBox";
            this.PictureQualityTextBox.Size = new System.Drawing.Size(444, 22);
            this.PictureQualityTextBox.TabIndex = 9;
            this.PictureQualityTextBox.TextChanged += new System.EventHandler(this.PictureQualityTextBox_TextChanged);
            // 
            // GuaranteePeriodLabel
            // 
            this.GuaranteePeriodLabel.Location = new System.Drawing.Point(13, 320);
            this.GuaranteePeriodLabel.Name = "GuaranteePeriodLabel";
            this.GuaranteePeriodLabel.Size = new System.Drawing.Size(447, 23);
            this.GuaranteePeriodLabel.TabIndex = 10;
            this.GuaranteePeriodLabel.Text = "Введите срок гарантии (целое положительное):";
            // 
            // GuaranteePeriodTextBox
            // 
            this.GuaranteePeriodTextBox.Location = new System.Drawing.Point(16, 346);
            this.GuaranteePeriodTextBox.Name = "GuaranteePeriodTextBox";
            this.GuaranteePeriodTextBox.Size = new System.Drawing.Size(444, 22);
            this.GuaranteePeriodTextBox.TabIndex = 11;
            this.GuaranteePeriodTextBox.TextChanged += new System.EventHandler(this.GuaranteePeriodTextBox_TextChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Enabled = false;
            this.ConfirmButton.Location = new System.Drawing.Point(78, 389);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(140, 48);
            this.ConfirmButton.TabIndex = 12;
            this.ConfirmButton.Text = "OK";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(244, 389);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 48);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 464);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.GuaranteePeriodTextBox);
            this.Controls.Add(this.GuaranteePeriodLabel);
            this.Controls.Add(this.PictureQualityTextBox);
            this.Controls.Add(this.PictureQualityLabel);
            this.Controls.Add(this.MemoryTextBox);
            this.Controls.Add(this.MemoryLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Name = "AddOrEditForm";
            this.Text = "AddOrEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label PictureQualityLabel;
        private System.Windows.Forms.TextBox PictureQualityTextBox;
        private System.Windows.Forms.Label GuaranteePeriodLabel;
        private System.Windows.Forms.TextBox GuaranteePeriodTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
    }
}