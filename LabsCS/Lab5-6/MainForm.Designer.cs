
namespace Lab5_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddWarehouseButton = new System.Windows.Forms.ToolStripButton();
            this.AddMechanicButton = new System.Windows.Forms.ToolStripButton();
            this.AddLoaderButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddSlowLoaderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMediumLoaderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFastLoaderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddWarehouseButton,
            this.AddMechanicButton,
            this.AddLoaderButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1489, 27);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // AddWarehouseButton
            // 
            this.AddWarehouseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddWarehouseButton.Image = ((System.Drawing.Image)(resources.GetObject("AddWarehouseButton.Image")));
            this.AddWarehouseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddWarehouseButton.Name = "AddWarehouseButton";
            this.AddWarehouseButton.Size = new System.Drawing.Size(122, 24);
            this.AddWarehouseButton.Text = "Добавить склад";
            this.AddWarehouseButton.Click += new System.EventHandler(this.AddWarehouseButton_Click);
            // 
            // AddMechanicButton
            // 
            this.AddMechanicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddMechanicButton.Enabled = false;
            this.AddMechanicButton.Image = ((System.Drawing.Image)(resources.GetObject("AddMechanicButton.Image")));
            this.AddMechanicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddMechanicButton.Name = "AddMechanicButton";
            this.AddMechanicButton.Size = new System.Drawing.Size(151, 24);
            this.AddMechanicButton.Text = "Добавить механика";
            this.AddMechanicButton.Click += new System.EventHandler(this.AddMechanicButton_Click);
            // 
            // AddLoaderButton
            // 
            this.AddLoaderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddLoaderButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSlowLoaderButton,
            this.AddMediumLoaderButton,
            this.AddFastLoaderButton});
            this.AddLoaderButton.Image = ((System.Drawing.Image)(resources.GetObject("AddLoaderButton.Image")));
            this.AddLoaderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddLoaderButton.Name = "AddLoaderButton";
            this.AddLoaderButton.Size = new System.Drawing.Size(165, 24);
            this.AddLoaderButton.Text = "Добавить погрузчик";
            // 
            // AddSlowLoaderButton
            // 
            this.AddSlowLoaderButton.Name = "AddSlowLoaderButton";
            this.AddSlowLoaderButton.Size = new System.Drawing.Size(250, 26);
            this.AddSlowLoaderButton.Text = "Медленный погрузчик";
            this.AddSlowLoaderButton.Click += new System.EventHandler(this.AddSlowLoaderButton_Click);
            // 
            // AddMediumLoaderButton
            // 
            this.AddMediumLoaderButton.Name = "AddMediumLoaderButton";
            this.AddMediumLoaderButton.Size = new System.Drawing.Size(250, 26);
            this.AddMediumLoaderButton.Text = "Средний погрузчик";
            this.AddMediumLoaderButton.Click += new System.EventHandler(this.AddMediumLoaderButton_Click);
            // 
            // AddFastLoaderButton
            // 
            this.AddFastLoaderButton.Name = "AddFastLoaderButton";
            this.AddFastLoaderButton.Size = new System.Drawing.Size(250, 26);
            this.AddFastLoaderButton.Text = "Быстрый погрузчик";
            this.AddFastLoaderButton.Click += new System.EventHandler(this.AddFastLoaderButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 31);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1145, 678);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // TextBox
            // 
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Location = new System.Drawing.Point(1163, 31);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(320, 678);
            this.TextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 723);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton AddWarehouseButton;
        private System.Windows.Forms.ToolStripButton AddMechanicButton;
        private System.Windows.Forms.ToolStripDropDownButton AddLoaderButton;
        private System.Windows.Forms.ToolStripMenuItem AddSlowLoaderButton;
        private System.Windows.Forms.ToolStripMenuItem AddMediumLoaderButton;
        private System.Windows.Forms.ToolStripMenuItem AddFastLoaderButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox TextBox;
    }
}

