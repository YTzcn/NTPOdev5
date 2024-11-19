using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev5
{
    class Calisan
    {
        public string Ad { get; set; }
        public Departman Departman { get; set; }
        public Calisan(string ad, Departman departman) { Ad = ad; Departman = departman; }
        public void BilgiYazdir() => Console.WriteLine($"{Ad} {Departman.Ad} departmanında çalışıyor.");
    }
}
