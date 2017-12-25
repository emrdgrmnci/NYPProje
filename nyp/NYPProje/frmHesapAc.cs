using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPProje
{
    public partial class frmHesapAc : Form
    {
        public frmHesapAc()
        {
            InitializeComponent();
        }

        private void frmHesapAc_Load(object sender, EventArgs e)
        {
            foreach (var item in Process.Musteri)
            {
                cmbMusteri.Items.Add(item.MusteriNo + "-" + item.Isim + " " + item.Soyisim);
                cmbhesapListe.Items.Add(item.MusteriNo + "-" + item.Isim + " " + item.Soyisim);
            }

            foreach (var item in Process.Hesaplar)
            {
                cmbParaEkle.Items.Add(item.HesapNo + "-" + (item.HesapDurum == true ? "Bireysel" : "Kurumsal"));
                cmbParaCek.Items.Add(item.HesapNo + "-" + (item.HesapDurum == true ? "Bireysel" : "Kurumsal"));
            }
        }

        private void HesapKaydet_Click(object sender, EventArgs e)
        {
            var result = new Result();
            if (cmbMusteri.SelectedIndex < 0)
            {
                MessageBox.Show("Müşteri Seçiniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(HesapNo.Text))
            {
                MessageBox.Show("Hesap Numarası Giriniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(Miktar.Text))
            {
                MessageBox.Show("Hesap Miktarı Giriniz");
                return;
            }

            int hesapNo;
            int miktar; 

            int.TryParse(HesapNo.Text, out hesapNo);
            int.TryParse(Miktar.Text, out miktar);

            if (hesapNo == 0)
            {
                MessageBox.Show("Geçerli Bir Hesap Numarası Giriniz");
                return;
            }
            
            var musteriNo = Process.Musteri[cmbMusteri.SelectedIndex].MusteriNo;
            var hesapTip = HesapTipi.Text == "Bireysel" ? true : false;

           result =  Process.HesapEkle(new Hesap
            {
                HesapDurum = hesapTip,
                HesapNo = hesapNo,
                Miktar = miktar,
                MusteriNo = musteriNo
            });

            MessageBox.Show(result.Message);
            HesapNo.Text = "";
            Miktar.Text = "";

            cmbParaEkle.Items.Clear();
            foreach (var item in Process.Hesaplar)
            {
                cmbParaEkle.Items.Add(item.HesapNo + "-" + (item.HesapDurum == true ? "Bireysel" : "Kurumsal"));
            }

            cmbParaCek.Items.Clear();
            foreach (var item in Process.Hesaplar)
            {
                cmbParaCek.Items.Add(item.HesapNo + "-" + (item.HesapDurum == true ? "Bireysel" : "Kurumsal"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var musteriNo = Process.Musteri[cmbhesapListe.SelectedIndex].MusteriNo;

            var hesaplar = Process.Hesaplar.Where(x => x.MusteriNo == musteriNo).Select(x => new
            {
                 AdSoyad = Process.Musteri.Where(y=>y.MusteriNo == musteriNo).Select(y=>y.Isim + " "+y.Soyisim).FirstOrDefault(),
                 HesapNo = x.HesapNo,
                 Miktar = x.Miktar,
                 HesapTipi = x.HesapDurum ? "Bireysel Hesap" : "Kurumsal Hesap"
            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = hesaplar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Hesabı Silmek İstediğinize Emin Misiniz?", "Hesap Sİl", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(SilHesapNo.Text))
                {
                    MessageBox.Show("Hesap Numarası Giriniz");
                    return;
                }

                int hesapNo;
                int.TryParse(SilHesapNo.Text, out hesapNo);

                if (hesapNo == 0)
                {
                    MessageBox.Show("Geçerli Bir Hesap Numarası Giriniz");
                    return;
                }

                Result result = new Result();

                result = Process.HesapSil(hesapNo);

                MessageBox.Show(result.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbParaEkle.SelectedIndex < 0)
            {
                MessageBox.Show("Hesap Seçiniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(ParaCekMiktar.Text))
            {
                MessageBox.Show("Miktar Giriniz");
                return;
            }

            int hesapNo = Process.Hesaplar[cmbParaEkle.SelectedIndex].HesapNo;
            int miktar;

            int.TryParse(ParaCekMiktar.Text, out miktar);

            if (miktar <= 0)
            {
                MessageBox.Show("Hesaba Eklenebilecek Miktar Giriniz");
                return;
            }
            Result result = new Result();

            result = Process.ParaEkle(hesapNo , miktar);

            if (result.Success)
            {
                var musteri = Process.Hesaplar.Where(x => x.HesapNo == hesapNo).Select(x => x.MusteriNo).FirstOrDefault();

                var liste = Process.Hesaplar.Where(x => x.MusteriNo == musteri).Select(x=>new {
                    AdSoyad = Process.Musteri.Where(y => y.MusteriNo == musteri).Select(y => y.Isim + " " + y.Soyisim).FirstOrDefault(),
                    HesapNo = x.HesapNo,
                    Miktar = x.Miktar,
                    HesapTipi = x.HesapDurum ? "Bireysel Hesap" : "Kurumsal Hesap"
                }).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = liste;
            }
            
            MessageBox.Show(result.Message);
            ParaCekMiktar.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cmbParaCek.SelectedIndex < 0)
            {
                MessageBox.Show("Hesap Seçiniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(ParaCekMik.Text))
            {
                MessageBox.Show("Miktar Giriniz");
                return;
            }

            int hesapNo = Process.Hesaplar[cmbParaCek.SelectedIndex].HesapNo;
            int miktar;

            int.TryParse(ParaCekMik.Text, out miktar);

            if (miktar <= 0)
            {
                MessageBox.Show("Hesaptan Çekebilecek Miktar Giriniz");
                return;
            }
            Result result = new Result();

            result = Process.ParaCek(hesapNo, miktar);

            if (result.Success)
            {
                var musteri = Process.Hesaplar.Where(x => x.HesapNo == hesapNo).Select(x => x.MusteriNo).FirstOrDefault();

                var liste = Process.Hesaplar.Where(x => x.MusteriNo == musteri).Select(x => new {
                    AdSoyad = Process.Musteri.Where(y => y.MusteriNo == musteri).Select(y => y.Isim + " " + y.Soyisim).FirstOrDefault(),
                    HesapNo = x.HesapNo,
                    Miktar = x.Miktar,
                    HesapTipi = x.HesapDurum ? "Bireysel Hesap" : "Kurumsal Hesap"
                }).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = liste;
            }

            MessageBox.Show(result.Message);
            ParaCekMik.Text = "";
        }
    }
}
