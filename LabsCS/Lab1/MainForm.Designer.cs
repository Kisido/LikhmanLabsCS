
namespace Lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstFractionTextLabel = new System.Windows.Forms.Label();
            this.SecondFractionTextLabel = new System.Windows.Forms.Label();
            this.FirstFractionLabel = new System.Windows.Forms.Label();
            this.SecondFractionLabel = new System.Windows.Forms.Label();
            this.FirstFractionButton = new System.Windows.Forms.Button();
            this.SecondFractionButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstFractionTextLabel
            // 
            this.FirstFractionTextLabel.Location = new System.Drawing.Point(12, 9);
            this.FirstFractionTextLabel.Name = "FirstFractionTextLabel";
            this.FirstFractionTextLabel.Size = new System.Drawing.Size(125, 22);
            this.FirstFractionTextLabel.TabIndex = 0;
            this.FirstFractionTextLabel.Text = "Первая дробь:";
            // 
            // SecondFractionTextLabel
            // 
            this.SecondFractionTextLabel.Location = new System.Drawing.Point(12, 48);
            this.SecondFractionTextLabel.Name = "SecondFractionTextLabel";
            this.SecondFractionTextLabel.Size = new System.Drawing.Size(125, 22);
            this.SecondFractionTextLabel.TabIndex = 2;
            this.SecondFractionTextLabel.Text = "Вторая дробь:";
            // 
            // FirstFractionLabel
            // 
            this.FirstFractionLabel.Location = new System.Drawing.Point(106, 9);
            this.FirstFractionLabel.Name = "FirstFractionLabel";
            this.FirstFractionLabel.Size = new System.Drawing.Size(96, 39);
            this.FirstFractionLabel.TabIndex = 3;
            // 
            // SecondFractionLabel
            // 
            this.SecondFractionLabel.Location = new System.Drawing.Point(107, 48);
            this.SecondFractionLabel.Name = "SecondFractionLabel";
            this.SecondFractionLabel.Size = new System.Drawing.Size(95, 49);
            this.SecondFractionLabel.TabIndex = 4;
            // 
            // FirstFractionButton
            // 
            this.FirstFractionButton.Location = new System.Drawing.Point(199, 9);
            this.FirstFractionButton.Name = "FirstFractionButton";
            this.FirstFractionButton.Size = new System.Drawing.Size(167, 61);
            this.FirstFractionButton.TabIndex = 5;
            this.FirstFractionButton.Text = "Ввести первую дробь";
            this.FirstFractionButton.UseVisualStyleBackColor = true;
            this.FirstFractionButton.Click += new System.EventHandler(this.FirstFractionButton_Click);
            // 
            // SecondFractionButton
            // 
            this.SecondFractionButton.Location = new System.Drawing.Point(372, 9);
            this.SecondFractionButton.Name = "SecondFractionButton";
            this.SecondFractionButton.Size = new System.Drawing.Size(158, 61);
            this.SecondFractionButton.TabIndex = 6;
            this.SecondFractionButton.Text = "Ввести вторую дробь";
            this.SecondFractionButton.UseVisualStyleBackColor = true;
            this.SecondFractionButton.Click += new System.EventHandler(this.SecondFractionButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Enabled = false;
            this.AdditionButton.Location = new System.Drawing.Point(12, 100);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(125, 65);
            this.AdditionButton.TabIndex = 7;
            this.AdditionButton.Text = "Сложить две дроби";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Enabled = false;
            this.SubtractionButton.Location = new System.Drawing.Point(143, 100);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(125, 65);
            this.SubtractionButton.TabIndex = 8;
            this.SubtractionButton.Text = "Вычесть из первой дроби вторую";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Enabled = false;
            this.MultiplicationButton.Location = new System.Drawing.Point(274, 100);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(125, 65);
            this.MultiplicationButton.TabIndex = 9;
            this.MultiplicationButton.Text = "Перемножить две дроби";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Enabled = false;
            this.DivisionButton.Location = new System.Drawing.Point(405, 100);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(125, 65);
            this.DivisionButton.TabIndex = 10;
            this.DivisionButton.Text = "Разделить первую дробь на вторую";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(540, 176);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.SubtractionButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.SecondFractionButton);
            this.Controls.Add(this.FirstFractionButton);
            this.Controls.Add(this.SecondFractionLabel);
            this.Controls.Add(this.FirstFractionLabel);
            this.Controls.Add(this.SecondFractionTextLabel);
            this.Controls.Add(this.FirstFractionTextLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FirstFractionTextLabel;
        private System.Windows.Forms.Label SecondFractionTextLabel;
        private System.Windows.Forms.Label FirstFractionLabel;
        private System.Windows.Forms.Label SecondFractionLabel;
        private System.Windows.Forms.Button FirstFractionButton;
        private System.Windows.Forms.Button SecondFractionButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button DivisionButton;
    }
}

