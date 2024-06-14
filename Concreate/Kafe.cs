using HarmanBistro.Enums;
using HarmanBistro.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmanBistro.Concreate
{
    public class Kafe
    {
        public Queue<Musteri> MusteriKuyrugu { get; set; }

        public List<Kasa> Kasalar { get; set; }
        public  Queue<Calisan> BostaCalisanlar {  get; set; }
        
        /// <summary>
        /// Kafenin açılışında oluşturulacak ilk nesneler,müşteriler ve çalışanların eklenmesi.
        /// </summary>
        public Kafe()
        {
            

            Kasalar = new List<Kasa>();
            int KasaSayisi = new Random().Next(3,4);

            for (int i = 0; i < KasaSayisi; i++)
            {
                Kasalar.Add(new Kasa()
                {
                    KasaNo = i + 1,
                   
                    Durum = (KasaDurum)(new Random().Next(2, 4))

                });

            }


            MusteriKuyrugu = new Queue<Musteri>();
            BostaCalisanlar = new Queue<Calisan>();

            IlkVeriler();
        }
      

        /// <summary>
        /// Musteri Ekleme Metodu
        /// </summary>
        /// <param name="musteri"></param>
        public void MusteriEkle(Musteri musteri)
        {
            MusteriKuyrugu.Enqueue(musteri);
        }

        /// <summary>
        /// Calisan Ekleme Metodu
        /// </summary>
        /// <param name="calisan"></param>
        public void CalisanEkle(Calisan calisan)
        {
            BostaCalisanlar.Enqueue(calisan);
        }
        public Musteri MusteriKuyrugundanAl()
        {
            return MusteriKuyrugu.Dequeue();

        }
        public Calisan CalisanKuyrugundanAl()
        {
            return BostaCalisanlar.Dequeue();

        }

        public void Calistir()
        {
            foreach (var kasa in Kasalar)
                if (kasa.Durum == KasaDurum.Bos)
                {
                    kasa.Musteri = MusteriKuyrugundanAl();
                    kasa.calisan = CalisanKuyrugundanAl();

                }
        }
        private void IlkVeriler()
        {
            //İlk Musteriler 
            Random rnd = new Random();
            int musteriSayisi = rnd.Next(3, 8);

            for (int i = 0; i < musteriSayisi; i++)
                MusteriEkle(DinamikKisiOlustur.MusteriOlustur());

            int calisanSayisi = rnd.Next(4, 6);

            for (int i = 0; i < calisanSayisi; i++)
                CalisanEkle(DinamikKisiOlustur.CalisanOlustur());
        }
    }
}
