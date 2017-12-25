namespace NYPProje
{
    partial class Container
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşterıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlıMusteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterıEkleToolStripMenuItem,
            this.kayıtlıMusteriToolStripMenuItem,
            this.hesapİşlemleriToolStripMenuItem,
            this.havaleToolStripMenuItem,
            this.hesapSilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterıEkleToolStripMenuItem
            // 
            this.müşterıEkleToolStripMenuItem.Name = "müşterıEkleToolStripMenuItem";
            this.müşterıEkleToolStripMenuItem.Size = new System.Drawing.Size(158, 36);
            this.müşterıEkleToolStripMenuItem.Text = "Müşterı Ekle";
            this.müşterıEkleToolStripMenuItem.Click += new System.EventHandler(this.müşterıEkleToolStripMenuItem_Click);
            // 
            // havaleToolStripMenuItem
            // 
            this.havaleToolStripMenuItem.Name = "havaleToolStripMenuItem";
            this.havaleToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.havaleToolStripMenuItem.Text = "Havale";
            this.havaleToolStripMenuItem.Click += new System.EventHandler(this.havaleToolStripMenuItem_Click);
            // 
            // kayıtlıMusteriToolStripMenuItem
            // 
            this.kayıtlıMusteriToolStripMenuItem.Name = "kayıtlıMusteriToolStripMenuItem";
            this.kayıtlıMusteriToolStripMenuItem.Size = new System.Drawing.Size(179, 36);
            this.kayıtlıMusteriToolStripMenuItem.Text = "Kayıtlı Musteri";
            this.kayıtlıMusteriToolStripMenuItem.Click += new System.EventHandler(this.kayıtlıMusteriToolStripMenuItem_Click);
            // 
            // hesapSilToolStripMenuItem
            // 
            this.hesapSilToolStripMenuItem.Name = "hesapSilToolStripMenuItem";
            this.hesapSilToolStripMenuItem.Size = new System.Drawing.Size(12, 36);
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.hesapİşlemleriToolStripMenuItem.Text = "Hesap İşlemleri";
            this.hesapİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.hesapİşlemleriToolStripMenuItem_Click);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 626);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Container";
            this.Text = "Container";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Container_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlıMusteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
    }
}