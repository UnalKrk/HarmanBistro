using HarmanBistro.Abstraction;
using HarmanBistro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmanBistro.Concreate
{
    public class Musteri:Kisi
    {
        public Urun Urun { get; set; }
        public EkUrun EkUrun { get; set; }


        /// <summary>
        /// Polimorfizm Uygulaması
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() +  $"  Siparis vermek istedigim urun = {Urun} ek urun olarak ise {EkUrun} almak istiyorum ";
        }
    }
}
