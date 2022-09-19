using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention (isimlendirme kuralı)
        public void Ekle (Product product)
        {
            Console.WriteLine("Tebrikler !Sepete Eklendi ; "+product.ProductName  );
        
        }
        public void Ekle2(string product,string description,double price  )
        {
            Console.WriteLine("Tebrikler !Sepete Eklendi ; " + product);
             
        }
    }
}
