using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPProje
{
   public class Hesap
    {
        public long HesapID { get; private set; }
        public double Miktar { get; set; }
        public int HesapNo { get;  set; }
        public int MusteriNo { get;  set; }
        public bool HesapDurum { get; set; } 
        
    }
}
