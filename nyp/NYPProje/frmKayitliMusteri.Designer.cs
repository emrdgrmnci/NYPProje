namespace NYPProje
{
    partial class frmKayitliMusteri
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
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.dataKayitliMusteri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataKayitliMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(301, 34);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(200, 31);
            this.txtMusteriNo.TabIndex = 0;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(301, 83);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(200, 31);
            this.txtMusteriAdi.TabIndex = 1;
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Location = new System.Drawing.Point(164, 39);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(116, 25);
            this.lblMusteriNo.TabIndex = 2;
            this.lblMusteriNo.Text = "Müşteri No";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(164, 83);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(120, 25);
            this.lblMusteriAdi.TabIndex = 3;
            this.lblMusteriAdi.Text = "Müşteri Adı";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(553, 34);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(136, 74);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // dataKayitliMusteri
            // 
            this.dataKayitliMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKayitliMusteri.Location = new System.Drawing.Point(25, 151);
            this.dataKayitliMusteri.Name = "dataKayitliMusteri";
            this.dataKayitliMusteri.RowTemplate.Height = 33;
            this.dataKayitliMusteri.Size = new System.Drawing.Size(773, 356);
            this.dataKayitliMusteri.TabIndex = 5;
            this.dataKayitliMusteri.Visible = false;
            // 
            // frmKayitliMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 662);
            this.Controls.Add(this.dataKayitliMusteri);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lblMusteriAdi);
            this.Controls.Add(this.lblMusteriNo);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.txtMusteriNo);
            this.Name = "frmKayitliMusteri";
            this.Text = "frmKayitliMusteri";
            ((System.ComponentModel.ISupportInitialize)(this.dataKayitliMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.DataGridView dataKayitliMusteri;
    }
}