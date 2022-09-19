// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyat = 12.5;

            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Id = 1;
            urun1.Price = 18.2;
            urun1.ProductName = "Muz";
            urun1.Description = "ithal";
            urun1.Stock = 25;

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.Price = 22.8;
            urun2.ProductName = "Ananas";
            urun2.Description = "yerli";
            urun2.Stock = 30;

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.ProductName);
                Console.WriteLine(urun.Description);
                Console.WriteLine(urun.Stock);
                Console.WriteLine("--------");

            }

            Console.WriteLine("-----Metotlar-----");


            //instance - örnek
            //encapsulation ( )
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //sepetManager.Ekle2("armut", "sarı", 1.5);
            //sepetManager.Ekle2("elma", "yeşil", 1.5);
            //sepetManager.Ekle2("muz", "ital", 1.5);


            Console.WriteLine("Pes etmek yok");
        }





    }




}








// dont repeat yourself - DRY