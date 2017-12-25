using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPProje
{
    public class Havale : Hesap
    {
        public int HavaleId { get; set; }
        public int GonderenMusteriNo { get; set; }
        public int GonderenHesapNo { get; set; }
        public int HavaleMiktari { get; set; }
        public int AliciMusteriNo { get; set; }
        public int AliciHesapNo { get; set; }
        public double KesilenMiktar { get; set; }
        public DateTime Tarih { get; set;}
        

    }
}
