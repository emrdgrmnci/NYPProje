namespace NYPProje
{
    partial class frmHesabaHavale
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHesapListeMusteri = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKendineMusteri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKendineHesap2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKendineHesap1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KendineMiktar = new System.Windows.Forms.TextBox();
            this.KendineButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBaskasinaHavaleYap = new System.Windows.Forms.Button();
            this.txtBaskasinaHavaleMiktari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbHesapSec = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHavaleYapilacakHesap = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMusteriSec = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbHavaleYapilacakMusteri = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cmbHesapListeMusteri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 591);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap İşlemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Seçiniz : ";
            // 
            // cmbHesapListeMusteri
            // 
            this.cmbHesapListeMusteri.FormattingEnabled = true;
            this.cmbHesapListeMusteri.Location = new System.Drawing.Point(29, 84);
            this.cmbHesapListeMusteri.Name = "cmbHesapListeMusteri";
            this.cmbHesapListeMusteri.Size = new System.Drawing.Size(290, 33);
            this.cmbHesapListeMusteri.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(966, 353);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Havale İşlemlerini Listele";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KendineButton);
            this.groupBox2.Controls.Add(this.KendineMiktar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbKendineHesap1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbKendineHesap2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbKendineMusteri);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(1110, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 591);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kendi Hesabına Havale Yap";
            // 
            // cmbKendineMusteri
            // 
            this.cmbKendineMusteri.FormattingEnabled = true;
            this.cmbKendineMusteri.Location = new System.Drawing.Point(22, 83);
            this.cmbKendineMusteri.Name = "cmbKendineMusteri";
            this.cmbKendineMusteri.Size = new System.Drawing.Size(602, 33);
            this.cmbKendineMusteri.TabIndex = 6;
            this.cmbKendineMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbKendineMusteri_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Müşteri Seçiniz : ";
            // 
            // cmbKendineHesap2
            // 
            this.cmbKendineHesap2.FormattingEnabled = true;
            this.cmbKendineHesap2.Items.AddRange(new object[] {
            "Hesapları Görebilmek İçin Müşteri Seçiniz"});
            this.cmbKendineHesap2.Location = new System.Drawing.Point(22, 283);
            this.cmbKendineHesap2.Name = "cmbKendineHesap2";
            this.cmbKendineHesap2.Size = new System.Drawing.Size(602, 33);
            this.cmbKendineHesap2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Havale Yapılacak Hesap Seçiniz : ";
            // 
            // cmbKendineHesap1
            // 
            this.cmbKendineHesap1.FormattingEnabled = true;
            this.cmbKendineHesap1.Items.AddRange(new object[] {
            "Hesapları Görebilmek İçin Müşteri Seçiniz"});
            this.cmbKendineHesap1.Location = new System.Drawing.Point(22, 182);
            this.cmbKendineHesap1.Name = "cmbKendineHesap1";
            this.cmbKendineHesap1.Size = new System.Drawing.Size(602, 33);
            this.cmbKendineHesap1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hesap Seçiniz : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Miktar Giriniz : ";
            // 
            // KendineMiktar
            // 
            this.KendineMiktar.Location = new System.Drawing.Point(22, 386);
            this.KendineMiktar.Name = "KendineMiktar";
            this.KendineMiktar.Size = new System.Drawing.Size(610, 31);
            this.KendineMiktar.TabIndex = 12;
            // 
            // KendineButton
            // 
            this.KendineButton.Location = new System.Drawing.Point(252, 444);
            this.KendineButton.Name = "KendineButton";
            this.KendineButton.Size = new System.Drawing.Size(148, 59);
            this.KendineButton.TabIndex = 13;
            this.KendineButton.Text = "Havale Yap";
            this.KendineButton.UseVisualStyleBackColor = true;
            this.KendineButton.Click += new System.EventHandler(this.KendineButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbHavaleYapilacakMusteri);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnBaskasinaHavaleYap);
            this.groupBox3.Controls.Add(this.txtBaskasinaHavaleMiktari);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbHesapSec);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmbHavaleYapilacakHesap);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbMusteriSec);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(27, 633);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(742, 684);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Başkasının Hesabına Havale Yap";
            // 
            // btnBaskasinaHavaleYap
            // 
            this.btnBaskasinaHavaleYap.Location = new System.Drawing.Point(252, 534);
            this.btnBaskasinaHavaleYap.Name = "btnBaskasinaHavaleYap";
            this.btnBaskasinaHavaleYap.Size = new System.Drawing.Size(148, 59);
            this.btnBaskasinaHavaleYap.TabIndex = 13;
            this.btnBaskasinaHavaleYap.Text = "Havale Yap";
            this.btnBaskasinaHavaleYap.UseVisualStyleBackColor = true;
            this.btnBaskasinaHavaleYap.Click += new System.EventHandler(this.btnBaskasinaHavaleYap_Click);
            // 
            // txtBaskasinaHavaleMiktari
            // 
            this.txtBaskasinaHavaleMiktari.Location = new System.Drawing.Point(30, 473);
            this.txtBaskasinaHavaleMiktari.Name = "txtBaskasinaHavaleMiktari";
            this.txtBaskasinaHavaleMiktari.Size = new System.Drawing.Size(610, 31);
            this.txtBaskasinaHavaleMiktari.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Miktar Giriniz : ";
            // 
            // cmbHesapSec
            // 
            this.cmbHesapSec.FormattingEnabled = true;
            this.cmbHesapSec.Items.AddRange(new object[] {
            "Hesapları Görebilmek İçin Müşteri Seçiniz"});
            this.cmbHesapSec.Location = new System.Drawing.Point(22, 182);
            this.cmbHesapSec.Name = "cmbHesapSec";
            this.cmbHesapSec.Size = new System.Drawing.Size(602, 33);
            this.cmbHesapSec.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hesap Seçiniz : ";
            // 
            // cmbHavaleYapilacakHesap
            // 
            this.cmbHavaleYapilacakHesap.FormattingEnabled = true;
            this.cmbHavaleYapilacakHesap.Items.AddRange(new object[] {
            "Hesapları Görebilmek İçin Müşteri Seçiniz"});
            this.cmbHavaleYapilacakHesap.Location = new System.Drawing.Point(30, 370);
            this.cmbHavaleYapilacakHesap.Name = "cmbHavaleYapilacakHesap";
            this.cmbHavaleYapilacakHesap.Size = new System.Drawing.Size(602, 33);
            this.cmbHavaleYapilacakHesap.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(424, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Havale Yapılacak Müşteri Hesabı Seçiniz : ";
            // 
            // cmbMusteriSec
            // 
            this.cmbMusteriSec.FormattingEnabled = true;
            this.cmbMusteriSec.Location = new System.Drawing.Point(22, 83);
            this.cmbMusteriSec.Name = "cmbMusteriSec";
            this.cmbMusteriSec.Size = new System.Drawing.Size(602, 33);
            this.cmbMusteriSec.TabIndex = 6;
            this.cmbMusteriSec.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriSec_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Müşteri Seçiniz : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 16;
            // 
            // cmbHavaleYapilacakMusteri
            // 
            this.cmbHavaleYapilacakMusteri.FormattingEnabled = true;
            this.cmbHavaleYapilacakMusteri.Location = new System.Drawing.Point(24, 271);
            this.cmbHavaleYapilacakMusteri.Name = "cmbHavaleYapilacakMusteri";
            this.cmbHavaleYapilacakMusteri.Size = new System.Drawing.Size(602, 33);
            this.cmbHavaleYapilacakMusteri.TabIndex = 15;
            this.cmbHavaleYapilacakMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbHavaleYapilacakMusteri_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(351, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Havale Yapılacak Müşteri Seçiniz : ";
            // 
            // frmHesabaHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1367);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHesabaHavale";
            this.Text = "frmHesabaHavale";
            this.Load += new System.EventHandler(this.frmHesabaHavale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbHesapListeMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button KendineButton;
        private System.Windows.Forms.TextBox KendineMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKendineHesap1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKendineHesap2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKendineMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbHavaleYapilacakMusteri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBaskasinaHavaleYap;
        private System.Windows.Forms.TextBox txtBaskasinaHavaleMiktari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbHesapSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHavaleYapilacakHesap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMusteriSec;
        private System.Windows.Forms.Label label9;
    }
}