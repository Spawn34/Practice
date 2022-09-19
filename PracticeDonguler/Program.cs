// See https://aka.ms/new-console-template for more information



string kurs1 = "sql kursu";
string kurs2 ="temel kurs";
string kurs3 = "java kursu";

Console.WriteLine(kurs1);
Console.WriteLine(kurs2);
Console.WriteLine(kurs3);

Console.WriteLine("SAYFA_AYIRACI");

// aray - dizi (yani liste olarak 1 kaynaktan yayınla ve düzenlemeyi tek bir listeden yap)

        string[] kurslar = new string[] { "sql kursu",
            "temel kurs",
            "java kursu",
            "pyton",
            "C++"
            };

Console.WriteLine(kurslar);


for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("for'un bitimi");
// dizinleri kolay dolaşmak için kullanırız yani farklı yöntem
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("Sayfa sonu - footer");