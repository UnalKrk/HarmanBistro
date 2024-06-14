using HarmanBistro.Concreate;
using HarmanBistro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmanBistro.Utility
{
    public static class DinamikKisiOlustur
    {
        /// <summary>
        /// Rastgele isimler olusturmak için olusturulan strin dizileri
        /// </summary>
        static string[] isimler = { "Ünal", "Zeynep", "Hakan", "Semih", "Tolga", "Onur", "Kerem", "Sefa", "Hüseyin","Melike","Cafer","Cemre" };
        static string[] soyisimler = { "Törer", "Fırat", "Tutan","Fidan","Ensar","Kork" };

        /// <summary>
        /// Calisan Olusturma Metodu
        /// </summary>
        /// <returns></returns>
        public static Calisan CalisanOlustur()
        {
            Calisan calisan = new Calisan()
            {
                Ad = isimler[new Random().Next(isimler.Length)],
                Soyad = soyisimler[new Random().Next(soyisimler.Length)],
                Cinsiyet = (Cinsiyet)(new Random().Next(1, 3))

            };

            return calisan;

        }
        /// <summary>
        /// Musteri Olusturma Metodu
        /// </summary>
        /// <returns></returns>
        public static Musteri MusteriOlustur()
        {

            Musteri musteri = new Musteri()
            {
                Ad = isimler[new Random().Next(isimler.Length)],
                Soyad = soyisimler[new Random().Next(soyisimler.Length)],
                Cinsiyet = (Cinsiyet)(new Random().Next(1, 3)),
                Urun= (Urun)new Random().Next(1,6),
                EkUrun=(EkUrun)new Random().Next(0,4)

            };
            
            return musteri;
        }
        
    }
}
