using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmanBistro.Abstraction;
using HarmanBistro.Interface;
using HarmanBistro.Enums;

namespace HarmanBistro.Concreate
{
    public class Calisan:Personel,ISiparisAlabilir,ISiparisHazilayabilir
    {
        public CalisanDurum Durum { get; set; }

    }
}
