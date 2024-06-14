using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmanBistro.Exceptions
{
    public class ArizaliKasayaMusteriAtamaException:Exception
    {
        public override string Message => "Arizali Kasaya Musteri atanamaz...";
    }
}
