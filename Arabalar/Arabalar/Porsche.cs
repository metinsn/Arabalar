using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabalar
{
    class Porsche : Araba
    {
        public Porsche()
        {
            seri = "GT";

            model = "GT";

            motorhacmi = 2000;

            motorgucu = 250;

        }
        public override string Calıstır()
        {
            return "vrom vrom vrom ";
        }
    }
}
