using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Product
    {
        //property - Özellik aşağıdaki diziye denir.
        //ürüne ait bilgilerin olduğu ve tanımlandığı alana "CLASS" denir.
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
    }
}
