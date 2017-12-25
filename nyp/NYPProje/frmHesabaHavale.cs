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
    public partial class frmHesabaHavale : Form
    {
        public frmHesabaHavale()
        {
            InitializeComponent();
        }
          
        private void btnIslemMusNo_Click(object sender, EventArgs e)
        {
           
            }

      
        private void frmHesabaHavale_Load(object sender, EventArgs e)
        {
            foreach (var item in Process.Musteri)
            {
                cmbHesapListeMusteri.Items.Add(item.MusteriNo + "-" + item.Isim + " " + item.Soyisim);
                cmbKendineMusteri.Items.Add(item.MusteriNo + "-" + item.Isim + " " + item.Soyisim);

                cmbHavaleYapilacakMusteri.Items.Add(item.MusteriNo + "-" + item.Isim + " " + item.Soyisim);
                cmbMusteriSec.Items.Add(item.MusteriNo + "-" + item.Isim + " " + item.Soyisim);
            }

            HavaleList();
        }

        private void cmbKendineMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int musteriNo = Process.Musteri[cmbKendineMusteri.SelectedIndex].MusteriNo;

            var liste = Process.Hesaplar.Where(x => x.MusteriNo == musteriNo).ToList();

            cmbKendineHesap1.Items.Clear();
            cmbKendineHesap2.Items.Clear();

            if (liste.Count > 0)
            {
                foreach (var item in liste)
                {
                    cmbKendineHesap1.Items.Add(item.HesapNo +" - "+ (item.HesapDurum == true ? "Bireysel" : "Kurumsal"));
                    cmbKendineHesap2.Items.Add(item.HesapNo +" - "+ (item.HesapDurum == true ? "Bireysel" : "Kurumsal"));
                }
            }
            else
            {
                cmbKendineHesap1.Items.Add("Bu Müşterinin Hesabı Bulunmamaktadır.");
                cmbKendineHesap2.Items.Add("Bu Müşterinin Hesabı Bulunmamaktadır.");
            }
        }

        private void KendineButton_Click(object sender, EventArgs e)
        {
            if (cmbKendineHesap1.SelectedIndex < 0)
            {
                MessageBox.Show("Hesap Seçiniz");
                return;
            }

            if (cmbKendineHesap2.SelectedIndex < 0)
            {
                MessageBox.Show("Havale Yapacağınız Hesabı Seçiniz");
                return;
            }

            if (cmbKendineHesap1.SelectedIndex == cmbKendineHesap2.SelectedIndex)
            {
                MessageBox.Show("Aynı Hesaba Havale Yapamazsınız");
                return;
            }

            if (string.IsNullOrWhiteSpace(KendineMiktar.Text))
            {
                MessageBox.Show("Havale Yapacağınız Miktar Giriniz");
                return;
            }
            int _miktar;

            int.TryParse(KendineMiktar.Text, out _miktar);

            if (_miktar == 0)
            {
                MessageBox.Show("Havale Yapacağınız Geçerli Bir Miktar Giriniz");
                return;
            }

            Result _result = new Result();

            _result = Process.HavaleEkle(Process.Hesaplar[cmbKendineHesap1.SelectedIndex].HesapNo , Process.Hesaplar[cmbKendineHesap2.SelectedIndex].HesapNo , _miktar);

            MessageBox.Show(_result.Message);
            HavaleList();
        }

        private void btnBaskasinaHavaleYap_Click(object sender, EventArgs e)
        {

            if (cmbHesapSec.SelectedIndex < 0)
            {
                MessageBox.Show("Hesap Seçiniz");
                return;
            }

            if (cmbHavaleYapilacakHesap.SelectedIndex < 0)
            {
                MessageBox.Show("Havale Yapacağınız Hesabı Seçiniz");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtBaskasinaHavaleMiktari.Text))
            {
                MessageBox.Show("Havale Yapacağınız Miktar Giriniz");
                return;
            }

            string _1 = cmbHesapSec.Text.Split('-')[0];
            string _2 = cmbHavaleYapilacakHesap.Text.Split('-')[0];

            int miktar;
            int hesap;
            int baskasi;

            int.TryParse(txtBaskasinaHavaleMiktari.Text, out miktar);
            int.TryParse(_1, out hesap);
            int.TryParse(_2, out baskasi);

            if (hesap == baskasi)
            {
                MessageBox.Show("Aynı Hesaba Havale Yapamazsınız");
                return;
            }

            if (miktar == 0)
            {
                MessageBox.Show("Havale Yapacağınız Geçerli Bir Miktar Giriniz");
                return;
            }

            Result result = new Result();

            result = Process.HavaleEkle(hesap, baskasi, miktar);

            MessageBox.Show(result.Message);
            HavaleList();


        }

        private void cmbMusteriSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int musteriNo = Process.Musteri[cmbMusteriSec.SelectedIndex].MusteriNo;

            var liste = Process.Hesaplar.Where(x => x.MusteriNo == musteriNo).ToList();

            cmbHesapSec.Items.Clear();

            if (liste.Count > 0)
            {
                foreach (var item in liste)
                {
                    cmbHesapSec.Items.Add(item.HesapNo + "-" + (item.HesapDurum == true ? "Bireysel" : "Kurumsal"));
                    
                }
            }
            else
            {
                cmbHesapSec.Items.Add("Bu Müşterinin Hesabı Bulunmamaktadır.");
                
            }

        }

        private void cmbHavaleYapilacakMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int musteriNo = Process.Musteri[cmbHavaleYapilacakMusteri.SelectedIndex].MusteriNo;

            var liste = Process.Hesaplar.Where(x => x.MusteriNo == musteriNo).ToList();

            cmbHavaleYapilacakHesap.Items.Clear();

            if (liste.Count > 0)
            {
                foreach (var item in liste)
                {
                    cmbHavaleYapilacakHesap.Items.Add(item.HesapNo + "-" + (item.HesapDurum == true ? "Bireysel" : "Kurumsal"));

                }
            }
            else
            {
                cmbHavaleYapilacakHesap.Items.Add("Bu Müşterinin Hesabı Bulunmamaktadır.");

            }
        }

        private void HavaleList()
        {
            var list = Process.HavaleIslemleri.Select(x => new
            {
                IslemId = x.HavaleId,
                GonderenAdSoyad = Process.Musteri.Where(y => y.MusteriNo == x.GonderenMusteriNo).Select(y => y.Isim + " " + y.Soyisim).FirstOrDefault(),
                AliciAdSoyad = Process.Musteri.Where(y => y.MusteriNo == x.AliciMusteriNo).Select(y => y.Isim + " " + y.Soyisim).FirstOrDefault(),
                HavaleMiktari = x.Miktar,
                KesimMiktari = x.KesilenMiktar,
                Tarih = String.Format("{0:dd MMMM yyyy HH:mm:ss}", x.Tarih)
            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }
    }
    }




