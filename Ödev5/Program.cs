using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev5
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== İlişki Türleri ===");
                Console.WriteLine("1. Yazar ve Kitap (Uni-directional)");
                Console.WriteLine("2. Çalışan ve Departman (Uni-directional)");
                Console.WriteLine("3. Ev ve Oda (Aggregation)");
                Console.WriteLine("4. Bilgisayar ve İşlemci (Composition)");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçiminizi yapın (1-5): ");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        YazarVeKitapOrnegi();
                        break;
                    case "2":
                        CalisanVeDepartmanOrnegi();
                        break;
                    case "3":
                        EvVeOdaOrnegi();
                        break;
                    case "4":
                        BilgisayarVeIslemciOrnegi();
                        break;
                    case "5":
                        Console.WriteLine("Programdan çıkılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim. Devam etmek için Enter'a basın.");
                        Console.ReadLine();
                        break;
                }
            }
        }
        static void YazarVeKitapOrnegi()
        {
            Yazar yazar = new Yazar("Orhan Pamuk");
            yazar.KitapEkle(new Kitap("Masumiyet Müzesi"));
            yazar.KitapEkle(new Kitap("Kırmızı Saçlı Kadın"));

            Console.Clear();
            yazar.KitaplariGoster();
            Console.WriteLine("\nDevam etmek için Enter'a basın.");
            Console.ReadLine();
        }

        // 2. Çalışan ve Departman (Uni-directional)
        static void CalisanVeDepartmanOrnegi()
        {
            Departman departman = new Departman("Yazılım Geliştirme");
            Calisan calisan = new Calisan("Ahmet", departman);

            Console.Clear();
            calisan.BilgiYazdir();
            Console.WriteLine("\nDevam etmek için Enter'a basın.");
            Console.ReadLine();
        }

        // 3. Ev ve Oda (Aggregation)
        static void EvVeOdaOrnegi()
        {
            Ev ev = new Ev("Villa");
            ev.OdaEkle(new Oda("Salon"));
            ev.OdaEkle(new Oda("Yatak Odası"));

            Console.Clear();
            ev.OdaBilgisi();
            Console.WriteLine("\nDevam etmek için Enter'a basın.");
            Console.ReadLine();
        }

        // 4. Bilgisayar ve İşlemci (Composition)
        static void BilgisayarVeIslemciOrnegi()
        {
            Bilgisayar pc = new Bilgisayar("Gaming PC", "Intel", "i9-13900K");

            Console.Clear();
            pc.BilgiGoster();
            Console.WriteLine("\nDevam etmek için Enter'a basın.");
            Console.ReadLine();
        }
    }
}

