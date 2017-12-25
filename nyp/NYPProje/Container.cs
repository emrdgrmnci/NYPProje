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
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void müşterıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            FrmMusteriEkle musteriEkle = new FrmMusteriEkle();
            musteriEkle.MdiParent = this;
            musteriEkle.WindowState = FormWindowState.Maximized;
            musteriEkle.Show();
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            frmHesabaHavale havale = new frmHesabaHavale();
            havale.MdiParent = this;
            havale.WindowState = FormWindowState.Maximized;
            havale.Show();
        }

        private void kayıtlıMusteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            frmKayitliMusteri kayitliMusteri = new frmKayitliMusteri();
            kayitliMusteri.MdiParent = this;
            kayitliMusteri.WindowState = FormWindowState.Maximized;
            kayitliMusteri.Show();
        }

       

        private void hesapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            frmHesapAc hesapIslem = new frmHesapAc();
            hesapIslem.MdiParent = this;
            hesapIslem.WindowState = FormWindowState.Maximized;
            hesapIslem.Show();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            FrmMusteriEkle musteriEkle = new FrmMusteriEkle();
            musteriEkle.MdiParent = this;
            musteriEkle.WindowState = FormWindowState.Maximized;
            musteriEkle.Show();
        }
    }
}
