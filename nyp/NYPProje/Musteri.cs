using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPProje
{
    public abstract class Musteri : MusteriDetay
    {

        public Musteri()
        {  }

        public abstract void MusteriEkle();

        public abstract void MusteriCikar();

        public override void MusteriEklendi()
        {
            base.MusteriEklendi();
        }

        public override void MusteriSilindi()
        {
            base.MusteriSilindi();
        }
    }
}
