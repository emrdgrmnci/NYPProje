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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }



        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {
            dataYeniHesap.DataSource = null;
            dataYeniHesap.DataSource = Process.Musteri;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                var result = new Result();

                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                int musNo = Convert.ToInt32(string.IsNullOrWhiteSpace(txtMusteriNo.Text) ? 0 : Convert.ToInt32(txtMusteriNo.Text));

                result = Process.MusteriEkle(new MusteriDetay
                {
                    Isim = ad,
                    MusteriNo = musNo,
                    Soyisim = soyad,
                    KayitTarihi = DateTime.Now,
                });

                MessageBox.Show(result.Message);

                dataYeniHesap.DataSource = null;
                dataYeniHesap.DataSource = Process.Musteri;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu.");
            }
        }

    }
}

