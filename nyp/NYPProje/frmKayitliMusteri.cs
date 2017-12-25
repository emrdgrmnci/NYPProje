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
    public partial class frmKayitliMusteri : Form
    {
        public frmKayitliMusteri()
        {
            InitializeComponent();
        }

        MusteriDetay mDetay = new MusteriDetay();

        List<MusteriDetay> kayitliMusteriListe = new List<MusteriDetay>();


        private void btnGoster_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtMusteriAdi.Text))
                {
                    MessageBox.Show("Müşteri Adı Giriniz");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMusteriNo.Text))
                {
                    MessageBox.Show("Müşteri Numarası Giriniz");
                    return;
                }

                string name = txtMusteriAdi.Text;
                int musteriNo = Convert.ToInt32(txtMusteriNo.Text);

                var musteri = Process.Musteri.Where(x => x.Isim == txtMusteriAdi.Text && x.MusteriNo == Convert.ToInt32(txtMusteriNo.Text)).FirstOrDefault();

                if (musteri != null)
                {
                    dataKayitliMusteri.DataSource = null;

                    dataKayitliMusteri.ColumnCount = 3; //datagridde kaç adet kolon olcak
                    dataKayitliMusteri.Columns[0].Name = "Müşteri No"; //1. kolon ismi
                    dataKayitliMusteri.Columns[1].Name = "İsim"; //2. kolon ismi
                    dataKayitliMusteri.Columns[2].Name = "Soyisim"; //3. kolon ismi

                    string[] row = new string[] { musteri.MusteriNo.ToString(),musteri.Isim, musteri.Soyisim}; 
                    dataKayitliMusteri.Rows.Add(row);

                    dataKayitliMusteri.Visible = true;
                  
                }
                else
                {
                    MessageBox.Show("Girilen Bilgilerde Müşteri Bulunamadı");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu!");
            }
        }
    }
}
