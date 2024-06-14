using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmanBistro.Enums;

namespace HarmanBistro.Abstraction
{
    public abstract class Kisi
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Cinsiyet Cinsiyet { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad} {Cinsiyet}";
        }

    }
}
