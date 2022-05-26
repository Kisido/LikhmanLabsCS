
namespace Lab2
{
    partial class AddDiamondForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CaratWeightLabel = new System.Windows.Forms.Label();
            this.CaratWeightTextBox = new System.Windows.Forms.TextBox();
            this.CutQualityLabel = new System.Windows.Forms.Label();
            this.CutQualityTextBox = new System.Windows.Forms.TextBox();
            this.FirstClassRadioButton = new System.Windows.Forms.RadioButton();
            this.SecondClassRadioButton = new System.Windows.Forms.RadioButton();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(13, 49);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(640, 23);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Введите название алмаза:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(16, 76);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(637, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CaratWeightLabel
            // 
            this.CaratWeightLabel.Location = new System.Drawing.Point(13, 115);
            this.CaratWeightLabel.Name = "CaratWeightLabel";
            this.CaratWeightLabel.Size = new System.Drawing.Size(640, 23);
            this.CaratWeightLabel.TabIndex = 2;
            this.CaratWeightLabel.Text = "Введите вес в каратах (целое число):";
            // 
            // CaratWeightTextBox
            // 
            this.CaratWeightTextBox.Location = new System.Drawing.Point(16, 141);
            this.CaratWeightTextBox.Name = "CaratWeightTextBox";
            this.CaratWeightTextBox.Size = new System.Drawing.Size(637, 22);
            this.CaratWeightTextBox.TabIndex = 3;
            this.CaratWeightTextBox.TextChanged += new System.EventHandler(this.CaratWeightTextBox_TextChanged);
            // 
            // CutQualityLabel
            // 
            this.CutQualityLabel.Location = new System.Drawing.Point(12, 183);
            this.CutQualityLabel.Name = "CutQualityLabel";
            this.CutQualityLabel.Size = new System.Drawing.Size(641, 23);
            this.CutQualityLabel.TabIndex = 4;
            this.CutQualityLabel.Text = "Введите качество огранки (целое число):";
            // 
            // CutQualityTextBox
            // 
            this.CutQualityTextBox.Location = new System.Drawing.Point(16, 209);
            this.CutQualityTextBox.Name = "CutQualityTextBox";
            this.CutQualityTextBox.Size = new System.Drawing.Size(637, 22);
            this.CutQualityTextBox.TabIndex = 5;
            this.CutQualityTextBox.TextChanged += new System.EventHandler(this.CutQualityTextBox_TextChanged);
            // 
            // FirstClassRadioButton
            // 
            this.FirstClassRadioButton.AutoSize = true;
            this.FirstClassRadioButton.Checked = true;
            this.FirstClassRadioButton.Location = new System.Drawing.Point(16, 12);
            this.FirstClassRadioButton.Name = "FirstClassRadioButton";
            this.FirstClassRadioButton.Size = new System.Drawing.Size(175, 21);
            this.FirstClassRadioButton.TabIndex = 6;
            this.FirstClassRadioButton.TabStop = true;
            this.FirstClassRadioButton.Text = "Алмаз первого класса";
            this.FirstClassRadioButton.UseVisualStyleBackColor = true;
            this.FirstClassRadioButton.CheckedChanged += new System.EventHandler(this.FirstClassRadioButton_CheckedChanged);
            // 
            // SecondClassRadioButton
            // 
            this.SecondClassRadioButton.AutoSize = true;
            this.SecondClassRadioButton.Location = new System.Drawing.Point(204, 12);
            this.SecondClassRadioButton.Name = "SecondClassRadioButton";
            this.SecondClassRadioButton.Size = new System.Drawing.Size(174, 21);
            this.SecondClassRadioButton.TabIndex = 7;
            this.SecondClassRadioButton.Text = "Алмаз второго класса";
            this.SecondClassRadioButton.UseVisualStyleBackColor = true;
            this.SecondClassRadioButton.CheckedChanged += new System.EventHandler(this.SecondClassRadioButton_CheckedChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.Enabled = false;
            this.ColorLabel.Location = new System.Drawing.Point(12, 248);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(641, 23);
            this.ColorLabel.TabIndex = 8;
            this.ColorLabel.Text = "Введите цвет:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Enabled = false;
            this.ColorTextBox.Location = new System.Drawing.Point(16, 274);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(637, 22);
            this.ColorTextBox.TabIndex = 9;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Enabled = false;
            this.ConfirmButton.Location = new System.Drawing.Point(131, 312);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(171, 62);
            this.ConfirmButton.TabIndex = 10;
            this.ConfirmButton.Text = "OK";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(354, 312);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(171, 62);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddDiamondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 386);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.SecondClassRadioButton);
            this.Controls.Add(this.FirstClassRadioButton);
            this.Controls.Add(this.CutQualityTextBox);
            this.Controls.Add(this.CutQualityLabel);
            this.Controls.Add(this.CaratWeightTextBox);
            this.Controls.Add(this.CaratWeightLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddDiamondForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDiamondForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label CaratWeightLabel;
        private System.Windows.Forms.TextBox CaratWeightTextBox;
        private System.Windows.Forms.Label CutQualityLabel;
        private System.Windows.Forms.TextBox CutQualityTextBox;
        private System.Windows.Forms.RadioButton FirstClassRadioButton;
        private System.Windows.Forms.RadioButton SecondClassRadioButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
    }
}