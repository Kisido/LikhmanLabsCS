
namespace Lab1
{
    partial class AddFractionForm
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
            this.NumeratorLabel = new System.Windows.Forms.Label();
            this.NumeratorTextBox = new System.Windows.Forms.TextBox();
            this.DenominatorLabel = new System.Windows.Forms.Label();
            this.DenominatorTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeratorLabel
            // 
            this.NumeratorLabel.Location = new System.Drawing.Point(9, 9);
            this.NumeratorLabel.Name = "NumeratorLabel";
            this.NumeratorLabel.Size = new System.Drawing.Size(178, 23);
            this.NumeratorLabel.TabIndex = 0;
            this.NumeratorLabel.Text = "Введите числитель:";
            // 
            // NumeratorTextBox
            // 
            this.NumeratorTextBox.Location = new System.Drawing.Point(12, 35);
            this.NumeratorTextBox.Name = "NumeratorTextBox";
            this.NumeratorTextBox.Size = new System.Drawing.Size(529, 22);
            this.NumeratorTextBox.TabIndex = 1;
            this.NumeratorTextBox.TextChanged += new System.EventHandler(this.NumeratorTextBox_TextChanged);
            // 
            // DenominatorLabel
            // 
            this.DenominatorLabel.Location = new System.Drawing.Point(9, 85);
            this.DenominatorLabel.Name = "DenominatorLabel";
            this.DenominatorLabel.Size = new System.Drawing.Size(178, 23);
            this.DenominatorLabel.TabIndex = 2;
            this.DenominatorLabel.Text = "Введите знаменатель:";
            // 
            // DenominatorTextBox
            // 
            this.DenominatorTextBox.Location = new System.Drawing.Point(12, 111);
            this.DenominatorTextBox.Name = "DenominatorTextBox";
            this.DenominatorTextBox.Size = new System.Drawing.Size(529, 22);
            this.DenominatorTextBox.TabIndex = 3;
            this.DenominatorTextBox.TextChanged += new System.EventHandler(this.DenominatorTextBox_TextChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Enabled = false;
            this.ConfirmButton.Location = new System.Drawing.Point(98, 151);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(129, 42);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "ОК";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(309, 151);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(129, 42);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddFractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 214);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DenominatorTextBox);
            this.Controls.Add(this.DenominatorLabel);
            this.Controls.Add(this.NumeratorTextBox);
            this.Controls.Add(this.NumeratorLabel);
            this.Name = "AddFractionForm";
            this.Text = "AddFractionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeratorLabel;
        private System.Windows.Forms.TextBox NumeratorTextBox;
        private System.Windows.Forms.Label DenominatorLabel;
        private System.Windows.Forms.TextBox DenominatorTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
    }
}