using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev5
{
    class Islemci
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public Islemci(string marka, string model) { Marka = marka; Model = model; }
        public void IslemciBilgisi() => Console.WriteLine($"İşlemci: {Marka} {Model}");
    }
}
