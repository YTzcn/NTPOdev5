using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev5
{
    class Yazar
    {
        public string Ad { get; set; }
        public List<Kitap> Kitaplar { get; set; }
        public Yazar(string ad) { Ad = ad; Kitaplar = new List<Kitap>(); }
        public void KitapEkle(Kitap kitap) { Kitaplar.Add(kitap); }
        public void KitaplariGoster()
        {
            Console.WriteLine($"{Ad} tarafından yazılan kitaplar:");
            foreach (var kitap in Kitaplar) Console.WriteLine($"- {kitap.Ad}");
        }
    }
}
