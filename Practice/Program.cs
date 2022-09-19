using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği eğer string bir tanımlama yapacaksınız veri tipi tanımlamalısınız. 
            //do not repeat your self - kendini tekrarlama
            string kategorietiketi = "kategori";
            int ogrenciSayisi = 3200;
            double notortalamaları = 1.50;
            bool sistemGirisYapmisMİ = false;
            double dolardun = 7.35;
            double dolarBugun = 7.45;

            //1
            if (dolardun>dolarBugun)
            {
                Console.WriteLine("düşüş oku(veya value değer dönen sql cümlecik)");
            }
            else if(dolardun<dolarBugun)
                {
                Console.WriteLine("artış oku (sqlcümleciği)");
                }
            else
            {
                Console.WriteLine("değişmedi oku");
            }

            //2
            if (sistemGirisYapmisMİ==true) 
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }

            Console.WriteLine(kategorietiketi);


        }
    }
}
