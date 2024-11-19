using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev5
{
    class Bilgisayar
    {
        public string Ad { get; set; }
        public Islemci Islemci { get; set; }
        public Bilgisayar(string ad, string islemciMarka, string islemciModel)
        {
            Ad = ad;
            Islemci = new Islemci(islemciMarka, islemciModel);
        }
        public void BilgiGoster()
        {
            Console.WriteLine($"{Ad} bilgisayarı:");
            Islemci.IslemciBilgisi();
        }
    }
}
