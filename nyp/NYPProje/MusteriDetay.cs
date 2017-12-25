using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPProje
{
    public class MusteriDetay
    {
        public int MusteriNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime KayitTarihi { get; set; }

        public virtual void MusteriEklendi() { }
        public virtual void MusteriSilindi() { }

    }
}
