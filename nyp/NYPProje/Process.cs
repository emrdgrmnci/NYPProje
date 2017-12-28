using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPProje
{
    static class Process
    {
        public static List<MusteriDetay> Musteri { get; set; }
        public static List<Havale> HavaleTutar { get; set; }
        public static List<Hesap> Hesaplar { get; set; }
        public static List<ParaIslemleri> ParaIslemleri { get; set; }
        public static List<Havale> HavaleIslemleri { get; set; }

        static Process()
        {
            Musteri = new List<MusteriDetay>();
            HavaleTutar = new List<Havale>();
            Hesaplar = new List<Hesap>();
            ParaIslemleri = new List<ParaIslemleri>();
            HavaleIslemleri = new List<Havale>();

        }
        public static Result MusteriEkle(MusteriDetay mus)
        {
            var MusteriEklendi = new MusteriDetay();
            
            var result = new Result();

            try
            {
                if (Musteri.Any(x=>x.MusteriNo == mus.MusteriNo))
                {
                    result.Success = false;
                    result.Message = "Bu Müşteri Numarası Kullanılmaktadır";
                    return result;
                }

                Musteri.Add(mus);
                result.Success = true;
                result.Message = "Müşteri Eklendi";
                
            }
            catch (Exception)
            {

                throw;
            }

            return result;
            
        }
        
        public static void MusteriSil(MusteriDetay mus)
        {
            Musteri.Remove(mus);
        }

        public static Result HesapEkle(Hesap h)
        {
            var result = new Result();

            try
            {
                if (Hesaplar.Any(x => x.HesapNo == h.HesapNo))
                {
                    result.Message = "Bu Hesap Numarası Kullanılıyor";
                    result.Success = false;
                    return result;
                }

                Hesaplar.Add(new Hesap
                {
                    MusteriNo = h.MusteriNo,
                    HesapDurum = h.HesapDurum,
                    HesapNo = h.HesapNo,
                    Miktar = h.Miktar
                });

                result.Success = true;
                result.Message = "Hesap Oluşturuldu";
            }
            catch (Exception)
            {
                result.Message = "Bir Hata Oluştu.Tekrar Deneyin";
            }

            return result;
        }
        public static Result HesapSil(int hesapNo)
        {
            var result = new Result();

            try
            {
                if (!Hesaplar.Any(x => x.HesapNo == hesapNo))
                {
                    result.Message = "Bu Numarada Bir Hesap Bulunamadı";
                    result.Success = false;
                    return result;
                }

                if (Hesaplar.Any(x => x.Miktar > 0 && x.HesapNo == hesapNo))
                {
                    result.Message = "Bu Hesap Silinebilmesi İçin Miktarın 0 Olması Gerekmektedir";
                    result.Success = false;
                    return result;
                }

                var sil = Hesaplar.Where(x => x.HesapNo == hesapNo).FirstOrDefault();
                Hesaplar.Remove(sil);

                result.Success = true;
                result.Message = "Hesap Silindi";
            }
            catch (Exception)
            {
                result.Message = "Bir Hata Oluştu.Tekrar Deneyin";
            }

            return result;
        }

        public static Result ParaEkle(int HesapNo, int Miktar)
        {
            var result = new Result();

            try
            {
                if (!Hesaplar.Any(x => x.HesapNo == HesapNo))
                {
                    result.Message = "Para Yatırmak İstediğiniz Hesap Bulunamadı";
                    result.Success = false;
                    return result;
                }

                ParaIslemleri.Add(new ParaIslemleri
                {
                    HesapNo = HesapNo,
                    Miktar = Miktar,
                    Tip = true,
                    Tarih = DateTime.Now
                });

                var hesap = Hesaplar.Where(x => x.HesapNo == HesapNo).FirstOrDefault();
                hesap.Miktar += Miktar;


                result.Success = true;
                result.Message = "Hesaba Para Eklendi";
            }
            catch (Exception ex)
            {
                result.Message = "Bir Hata Oluştu.Tekrar Deneyin";
            }

            return result;
        }
        public static Result ParaCek(int HesapNo, int Miktar)
        {
            var result = new Result();

            try
            {
                if (!Hesaplar.Any(x => x.HesapNo == HesapNo))
                {
                    result.Message = "Para Çekmek İstediğiniz Hesap Bulunamadı";
                    result.Success = false;
                    return result;
                }

                var hesapDetay = Hesaplar.Where(x => x.HesapNo == HesapNo).FirstOrDefault();

                if (Miktar > hesapDetay.Miktar)
                {
                    result.Message = "Hesabınızda Çekmek İstediğiniz Kadar Miktar Bulunmamaktadır";
                    result.Success = false;
                    return result;
                }

                var hesaplar = Hesaplar.Where(x => x.MusteriNo == hesapDetay.MusteriNo).Select(x => x.HesapNo).ToList();

                var cekilenMiktar = ParaIslemleri.Where(x => hesaplar.Contains(x.HesapNo) && x.Tip == false && x.Tarih > DateTime.Now.AddDays(-1)).Sum(x => x.Miktar);

                if (cekilenMiktar + Miktar > 750)
                {
                    result.Message = "Günlük Para Çekme Limitini Aştınız.Para Çekme İşlemi İptal Edildi";
                    result.Success = false;
                    return result;
                }

                ParaIslemleri.Add(new ParaIslemleri
                {
                    HesapNo = HesapNo,
                    Miktar = Miktar,
                    Tip = false,
                    Tarih = DateTime.Now
                });

                hesapDetay.Miktar -= Miktar;

                result.Success = true;
                result.Message = "Hesaptan Para Çekildi";
            }
            catch (Exception ex)
            {
                result.Message = "Bir Hata Oluştu.Tekrar Deneyin";
            }

            return result;
        }

        public static Result HavaleEkle(int GonderenHesapNo, int AliciHesapNo, int Miktar)
        {
            var result = new Result();

            try
            {
                if (!Hesaplar.Any(x => x.HesapNo == GonderenHesapNo))
                {
                    result.Message = "Gönderen Hesabı Bulunamadı";
                    result.Success = false;
                    return result;
                }

                if (!Hesaplar.Any(x => x.HesapNo == AliciHesapNo))
                {
                    result.Message = "Alıcı Hesabı Bulunamadı";
                    result.Success = false;
                    return result;
                }

                var gonderenHesap = Process.Hesaplar.Where(x => x.HesapNo == GonderenHesapNo).FirstOrDefault();

                if (gonderenHesap.Miktar < Miktar)
                {
                    result.Message = "Gönderen Hesabında Havale Yapmak İstediğiniz Miktar Bulunamadı";
                    result.Success = false;
                    return result;
                }

                var aliciHesap = Process.Hesaplar.Where(x => x.HesapNo == AliciHesapNo).FirstOrDefault();

                double kesilen = Miktar - (gonderenHesap.HesapDurum == true ? Miktar * 0.02 : 0);

                HavaleIslemleri.Add(new Havale
                {
                    AliciHesapNo = AliciHesapNo,
                    AliciMusteriNo = aliciHesap.MusteriNo,
                    GonderenMusteriNo = gonderenHesap.MusteriNo,
                    GonderenHesapNo = gonderenHesap.HesapNo,
                    HavaleId = HavaleIslemleri.Count + 1,
                    Miktar = Miktar,
                    Tarih = DateTime.Now,
                    KesilenMiktar = Convert.ToDouble(gonderenHesap.HesapDurum == true ? Miktar * 0.02 : 0)
                });

                gonderenHesap.Miktar -= Miktar;
                aliciHesap.Miktar += kesilen;

                result.Success = true;
                result.Message = "Hesaba Havale İşlemi Yapıldı";
            }
            catch (Exception ex)
            {
                result.Message = "Bir Hata Oluştu.Tekrar Deneyin";
            }

            return result;
        }
    }
}
