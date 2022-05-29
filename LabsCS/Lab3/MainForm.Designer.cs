
namespace Lab3
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
            this.VideoPlayerListBox = new System.Windows.Forms.ListBox();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ActionToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AskInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WatchVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoneyTextLabel = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.BuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // VideoPlayerListBox
            // 
            this.VideoPlayerListBox.FormattingEnabled = true;
            this.VideoPlayerListBox.ItemHeight = 16;
            this.VideoPlayerListBox.Location = new System.Drawing.Point(13, 48);
            this.VideoPlayerListBox.Name = "VideoPlayerListBox";
            this.VideoPlayerListBox.Size = new System.Drawing.Size(937, 388);
            this.VideoPlayerListBox.TabIndex = 0;
            this.VideoPlayerListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VideoPlayerListBox_MouseDoubleClick);
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripButton,
            this.DeleteToolStripButton,
            this.ActionToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(962, 27);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // AddToolStripButton
            // 
            this.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToolStripButton.Image")));
            this.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToolStripButton.Name = "AddToolStripButton";
            this.AddToolStripButton.Size = new System.Drawing.Size(80, 24);
            this.AddToolStripButton.Text = "Добавить";
            this.AddToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton.Image")));
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(69, 24);
            this.DeleteToolStripButton.Text = "Удалить";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // ActionToolStripButton
            // 
            this.ActionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ActionToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AskInfoToolStripMenuItem,
            this.WatchVideoToolStripMenuItem,
            this.ChangeVolumeToolStripMenuItem,
            this.BuyToolStripMenuItem,
            this.RateToolStripMenuItem});
            this.ActionToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ActionToolStripButton.Image")));
            this.ActionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActionToolStripButton.Name = "ActionToolStripButton";
            this.ActionToolStripButton.Size = new System.Drawing.Size(296, 24);
            this.ActionToolStripButton.Text = "Действия с выбранным видеоплеером";
            // 
            // AskInfoToolStripMenuItem
            // 
            this.AskInfoToolStripMenuItem.Name = "AskInfoToolStripMenuItem";
            this.AskInfoToolStripMenuItem.Size = new System.Drawing.Size(431, 26);
            this.AskInfoToolStripMenuItem.Text = "Спросить информацию о плеере у консультанта";
            this.AskInfoToolStripMenuItem.Click += new System.EventHandler(this.AskInfoToolStripMenuItem_Click);
            // 
            // WatchVideoToolStripMenuItem
            // 
            this.WatchVideoToolStripMenuItem.Name = "WatchVideoToolStripMenuItem";
            this.WatchVideoToolStripMenuItem.Size = new System.Drawing.Size(431, 26);
            this.WatchVideoToolStripMenuItem.Text = "Посмотреть видео";
            this.WatchVideoToolStripMenuItem.Click += new System.EventHandler(this.WatchVideoToolStripMenuItem_Click);
            // 
            // ChangeVolumeToolStripMenuItem
            // 
            this.ChangeVolumeToolStripMenuItem.Name = "ChangeVolumeToolStripMenuItem";
            this.ChangeVolumeToolStripMenuItem.Size = new System.Drawing.Size(431, 26);
            this.ChangeVolumeToolStripMenuItem.Text = "Изменить громкость";
            this.ChangeVolumeToolStripMenuItem.Click += new System.EventHandler(this.ChangeVolumeToolStripMenuItem_Click);
            // 
            // MoneyTextLabel
            // 
            this.MoneyTextLabel.Location = new System.Drawing.Point(803, 22);
            this.MoneyTextLabel.Name = "MoneyTextLabel";
            this.MoneyTextLabel.Size = new System.Drawing.Size(100, 23);
            this.MoneyTextLabel.TabIndex = 2;
            this.MoneyTextLabel.Text = "Ваши деньги:";
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.Location = new System.Drawing.Point(909, 22);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(41, 23);
            this.MoneyLabel.TabIndex = 3;
            // 
            // BuyToolStripMenuItem
            // 
            this.BuyToolStripMenuItem.Name = "BuyToolStripMenuItem";
            this.BuyToolStripMenuItem.Size = new System.Drawing.Size(431, 26);
            this.BuyToolStripMenuItem.Text = "Купить плеер";
            this.BuyToolStripMenuItem.Click += new System.EventHandler(this.BuyToolStripMenuItem_Click);
            // 
            // RateToolStripMenuItem
            // 
            this.RateToolStripMenuItem.Name = "RateToolStripMenuItem";
            this.RateToolStripMenuItem.Size = new System.Drawing.Size(431, 26);
            this.RateToolStripMenuItem.Text = "Оценить товар";
            this.RateToolStripMenuItem.Click += new System.EventHandler(this.RateToolStripMenuItem_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(13, 443);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(937, 23);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "Если вы хотите изменить информацию о каком-либо товаре, то сделайте двйоной щелчо" +
    "к лкм по соответствующему товару";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 467);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.MoneyTextLabel);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.VideoPlayerListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox VideoPlayerListBox;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton AddToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton ActionToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem AskInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WatchVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeVolumeToolStripMenuItem;
        private System.Windows.Forms.Label MoneyTextLabel;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.ToolStripMenuItem BuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RateToolStripMenuItem;
        private System.Windows.Forms.Label InfoLabel;
    }
}

