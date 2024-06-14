using HarmanBistro.Enums;
using HarmanBistro.Exceptions;
using HarmanBistro.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmanBistro.Concreate
{
    public class Kasa
    {

        public int KasaNo { get; set; }
        public KasaDurum Durum { get; set; }
        public ISiparisAlabilir Personel { get; set; }
        public Calisan calisan { get; set; }

        Musteri _musteri;
        public Musteri Musteri
        {
            get { return _musteri; }
            set
            {
                if (Durum == KasaDurum.Arizali && value != null)
                {
                    throw new ArizaliKasayaMusteriAtamaException();
                }
                _musteri = value;
                if (value == null)
                    Durum = KasaDurum.Bos;
                else
                    Durum = KasaDurum.Dolu;


            }

        }


        public override string ToString()
        {
            return $"{KasaNo} {Durum} Calisan Bilgisi = {calisan} =>{Musteri}";

        }
    }
}
