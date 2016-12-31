using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabalar
{
    class Tofas : Araba
    {
        public Tofas()
        {
            seri = "Serçe";

            model = "Murat 131";

            motorgucu = 30;

            motorhacmi = 1400;
        }
        public override string Calıstır()
        {
            return "tır tır tır ";
        }

    }
}
