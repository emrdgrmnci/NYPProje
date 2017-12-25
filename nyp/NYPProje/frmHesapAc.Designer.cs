namespace NYPProje
{
    partial class frmHesapAc
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
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.HesapTipi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HesapNo = new System.Windows.Forms.TextBox();
            this.Miktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HesapKaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbhesapListe = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SilHesapNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbParaEkle = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ParaCekMiktar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ParaCekMik = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbParaCek = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(22, 92);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(386, 33);
            this.cmbMusteri.TabIndex = 0;
            // 
            // HesapTipi
            // 
            this.HesapTipi.FormattingEnabled = true;
            this.HesapTipi.Items.AddRange(new object[] {
            "Bireysel",
            "Kurumsal"});
            this.HesapTipi.Location = new System.Drawing.Point(22, 387);
            this.HesapTipi.Name = "HesapTipi";
            this.HesapTipi.Size = new System.Drawing.Size(386, 33);
            this.HesapTipi.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HesapKaydet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.HesapTipi);
            this.groupBox1.Controls.Add(this.Miktar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.HesapNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMusteri);
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 546);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Hesap Oluştur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri seçiniz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hesap Numarası Giriniz : ";
            // 
            // HesapNo
            // 
            this.HesapNo.Location = new System.Drawing.Point(22, 193);
            this.HesapNo.Name = "HesapNo";
            this.HesapNo.Size = new System.Drawing.Size(386, 31);
            this.HesapNo.TabIndex = 3;
            // 
            // Miktar
            // 
            this.Miktar.Location = new System.Drawing.Point(22, 289);
            this.Miktar.Name = "Miktar";
            this.Miktar.Size = new System.Drawing.Size(386, 31);
            this.Miktar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hesap Miktarı Giriniz : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hesap Tipi Seçiniz :";
            // 
            // HesapKaydet
            // 
            this.HesapKaydet.Location = new System.Drawing.Point(159, 452);
            this.HesapKaydet.Name = "HesapKaydet";
            this.HesapKaydet.Size = new System.Drawing.Size(135, 42);
            this.HesapKaydet.TabIndex = 7;
            this.HesapKaydet.Text = "Kaydet";
            this.HesapKaydet.UseVisualStyleBackColor = true;
            this.HesapKaydet.Click += new System.EventHandler(this.HesapKaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbhesapListe);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(503, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 536);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteriye Ait Hesaplar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(797, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Müşteri seçiniz : ";
            // 
            // cmbhesapListe
            // 
            this.cmbhesapListe.FormattingEnabled = true;
            this.cmbhesapListe.Location = new System.Drawing.Point(31, 91);
            this.cmbhesapListe.Name = "cmbhesapListe";
            this.cmbhesapListe.Size = new System.Drawing.Size(386, 33);
            this.cmbhesapListe.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hesapları Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.SilHesapNo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(1404, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 536);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hesap Sil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 778);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 5;
            // 
            // SilHesapNo
            // 
            this.SilHesapNo.Location = new System.Drawing.Point(22, 92);
            this.SilHesapNo.Name = "SilHesapNo";
            this.SilHesapNo.Size = new System.Drawing.Size(386, 31);
            this.SilHesapNo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hesap Numarası Giriniz : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hesap Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ParaCekMiktar);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cmbParaEkle);
            this.groupBox4.Location = new System.Drawing.Point(32, 615);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 320);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hesaba Para Ekle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Hesap seçiniz : ";
            // 
            // cmbParaEkle
            // 
            this.cmbParaEkle.FormattingEnabled = true;
            this.cmbParaEkle.Location = new System.Drawing.Point(15, 86);
            this.cmbParaEkle.Name = "cmbParaEkle";
            this.cmbParaEkle.Size = new System.Drawing.Size(386, 33);
            this.cmbParaEkle.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Hesaba Para Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ParaCekMiktar
            // 
            this.ParaCekMiktar.Location = new System.Drawing.Point(15, 184);
            this.ParaCekMiktar.Name = "ParaCekMiktar";
            this.ParaCekMiktar.Size = new System.Drawing.Size(386, 31);
            this.ParaCekMiktar.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Miktarı Giriniz : ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ParaCekMik);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.cmbParaCek);
            this.groupBox5.Location = new System.Drawing.Point(503, 615);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(431, 320);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hesaptan Para Çek";
            // 
            // ParaCekMik
            // 
            this.ParaCekMik.Location = new System.Drawing.Point(15, 184);
            this.ParaCekMik.Name = "ParaCekMik";
            this.ParaCekMik.Size = new System.Drawing.Size(386, 31);
            this.ParaCekMik.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(58, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(295, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hesaptan Para Çek";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Miktarı Giriniz : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Hesap seçiniz : ";
            // 
            // cmbParaCek
            // 
            this.cmbParaCek.FormattingEnabled = true;
            this.cmbParaCek.Location = new System.Drawing.Point(15, 86);
            this.cmbParaCek.Name = "cmbParaCek";
            this.cmbParaCek.Size = new System.Drawing.Size(386, 33);
            this.cmbParaCek.TabIndex = 2;
            // 
            // frmHesapAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1991, 965);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHesapAc";
            this.Text = "frmHesapAc";
            this.Load += new System.EventHandler(this.frmHesapAc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox HesapTipi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox HesapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HesapKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Miktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbhesapListe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SilHesapNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbParaEkle;
        private System.Windows.Forms.TextBox ParaCekMiktar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox ParaCekMik;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbParaCek;
    }
}