using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabalar
{
    class Araba
    {
        public string seri { get; set; }

        public string model { get; set; }

        public int motorhacmi { get; set; }

        public int motorgucu { get; set; }

        public string Yadır()
        {
            return string.Format("Seri \t\t:{0} \nmodel \t\t:{1} \nmotorhacmi \t\t:{2} \nmotorgucu \t\t:{3}", seri, model, motorhacmi, motorgucu);
        }
        public virtual string Calıstır()
        {
            return "Araba Çalıştı ";
        }
    }
}
