using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev5
{
    class Ev
    {
        public string Ad { get; set; }
        public List<Oda> Odalar { get; set; }
        public Ev(string ad) { Ad = ad; Odalar = new List<Oda>(); }
        public void OdaEkle(Oda oda) { Odalar.Add(oda); }
        public void OdaBilgisi()
        {
            Console.WriteLine($"{Ad} evindeki odalar:");
            foreach (var oda in Odalar) Console.WriteLine($"- {oda.Ad}");
        }
    }
}
