
namespace ClassIntro_practice
{ 
    class program
     { 

        static void Main(string[]args)
        { 
             string ad="ertuğrul";
             int yas = 26;





            Kurs kurs1 = new Kurs();
            kurs1.Egitmeni="ertuğrul kurdal";
            kurs1.fiyat=39;
            kurs1.Indırımoranı="20";
            kurs1.Izlenmeoranı=79;
            kurs1.KursAdi="MSSQL";

            Kurs kurs2 = new Kurs();
            kurs2.Egitmeni="nurdan kurdal";
            kurs2.fiyat=70;
            kurs2.Indırımoranı="10";
            kurs2.Izlenmeoranı=35;
            kurs2.KursAdi="java";

            Kurs kurs3 = new Kurs();
            kurs3.Egitmeni="hatice kurdal";
            kurs3.fiyat=51;
            kurs3.Indırımoranı="30";
            kurs3.Izlenmeoranı=22;
            kurs3.KursAdi="C++";

            //Console.WriteLine(kurs1.Egitmeni+" "+kurs1.KursAdi+" "+kurs1.Izlenmeoranı);
            //Console.WriteLine(kurs2.Egitmeni+" "+kurs2.KursAdi+" "+kurs2.Izlenmeoranı);
            //Console.WriteLine(kurs3.Egitmeni+" "+kurs3.KursAdi+" "+kurs3.Izlenmeoranı);
            
            
            Kurs[] kurslar= new Kurs[]{kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
            
                
                Console.WriteLine("Selam Dünya!");
        }
    }





        class Kurs
        {
             public string KursAdi { get; set; }
             public string Egitmeni { get; set; }
             public int Izlenmeoranı { get; set; }
             public int fiyat { get; set; }
             public string Indırımoranı { get; set; }

        }

}

