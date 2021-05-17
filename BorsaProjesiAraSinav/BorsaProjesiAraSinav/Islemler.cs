using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesiAraSinav
{
    public class Islemler
    {
        public static DatabaseEntities entities = new DatabaseEntities();
        public static List<string> islemler = new List<string>();
        public static bool Kullanicivarmi(string Kullaniciadi)
        {
            return entities.Kullanicilar.Find(Kullaniciadi) != null;
        }
        public static Kullanici Giris(string kadi,string sifre)
        {
            foreach (Kullanici kullanici in entities.Kullanicilar)
            {
                if (kullanici.Kullaniciadi==kadi&&kullanici.Sifre==sifre)
                {
                    return kullanici;
                }
            }
            return null;
        }
        public static string[] urunler()
        {
            return new string[] { "Buğday","Arpa","Yulaf","Petrol","Pamuk"};
        }
        private static int KacAdetAlabilir(KullaniciTalep talep,KullaniciUrun urun)
        {
            Kullanici alici = talep.Kullanici;
            int talepAdet = (int)talep.Talep.TalepMiktari;
            if (urun.Urun.Miktar<talepAdet)
            {
                talepAdet = (int)urun.Urun.Miktar;
            }
            if (alici.Bakiye<talepAdet*urun.Urun.BirimFiyat)
            {
                talepAdet = (int)(alici.Bakiye / urun.Urun.BirimFiyat);
            }
            return talepAdet;
        }
        private static void SatisUygula(Kullanici alici,Kullanici satici,KullaniciUrun urun,int miktar)
        {
            int tutar = (int)(miktar * urun.Urun.BirimFiyat);
            alici.Bakiye -= tutar;
            satici.Bakiye += tutar;
            KullaniciUrun satilan = new KullaniciUrun();
            satilan.Urun = new Urun();
            satilan.Urun.UrunAdi = urun.Urun.UrunAdi;
            satilan.Urun.Miktar = miktar;
            satilan.Urun.Onay = 1;
            satilan.Urun.BirimFiyat = urun.Urun.BirimFiyat;
            satilan.Kullanici = alici;
            alici.Urunler.Add(satilan);
            urun.Urun.Miktar -= miktar;
            islemler.Add(DateTime.Now.ToString() + " Tarihinde " + alici.Kullaniciadi + " isimli alıcı " + satici.Kullaniciadi + " satıcısından " + miktar + " kilo " + urun.Urun.UrunAdi +
                " satın aldı. Ödenen Tutar: " + tutar + " TL, " + alici.Kullaniciadi + " alıcısının kalan bakiyesi: " + alici.Bakiye + " TL. Birim Fiyat: " + urun.Urun.BirimFiyat+" TL");
        }
        private static KullaniciUrun EnUcuzUrunBul(string Urunadi,Kullanici alici)
        {
            KullaniciUrun enUcuz = null;
            foreach (Kullanici satici in entities.Kullanicilar)
            {
                if (alici!=satici)
                {
                    foreach (KullaniciUrun urun in satici.Urunler)
                    {
                        if (enUcuz==null&&urun.Urun.UrunAdi == Urunadi)
                        {
                            enUcuz = urun;
                        }
                        else if (urun.Urun.UrunAdi==Urunadi && urun.Urun.BirimFiyat<enUcuz.Urun.BirimFiyat)
                        {
                            enUcuz = urun;
                        }
                    }
                }
            }
            return enUcuz;
        }
        private static void KullanicTalepleriniUygula(Kullanici alici)
        {
            foreach (KullaniciTalep talep in alici.Talepler)
            {
                KullaniciUrun enucuz = EnUcuzUrunBul(talep.Talep.UrunAdi,alici);
                if (enucuz!=null)
                {
                    int miktar = KacAdetAlabilir(talep, enucuz);
                    if (miktar>0)
                    {
                        SatisUygula(alici, enucuz.Kullanici, enucuz, miktar);
                        talep.Talep.TalepMiktari -= miktar;
                    }
                }
            }
            UrunleriTemizle();
        }
        private static void UrunleriTemizle()
        {
            List<KullaniciUrun> temp = new List<KullaniciUrun>();
            List<KullaniciTalep> temp2 = new List<KullaniciTalep>();
            foreach (Kullanici kullanici in entities.Kullanicilar)
            {
                foreach (KullaniciUrun urun in kullanici.Urunler)
                {
                    if (urun.Urun.Miktar==0)
                    {
                        temp.Add(urun);
                    }
                }
                foreach (KullaniciTalep talep in kullanici.Talepler)
                {
                    if (talep.Talep.TalepMiktari==0)
                    {
                        temp2.Add(talep);
                    }
                }
            }
            foreach (KullaniciUrun urun in temp)
            {
                entities.KullaniciUrunleri.Remove(urun);
            }
            foreach (KullaniciTalep talep1 in temp2)
            {
                entities.KullaniciTalepleri.Remove(talep1);
            }
        }
        public static void AlimSatimGerceklestir()
        {
            foreach (Kullanici alici in entities.Kullanicilar)
            {
                KullanicTalepleriniUygula(alici);
            }
            entities.SaveChanges();
        }
    }
}
