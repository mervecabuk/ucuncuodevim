using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucuncuodevim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // piramit yapma ödevi. önce Artan şekil
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Azalan şekil
            for (int i = 7; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Piramit şekli
            int n = 5; // Piramidin yüksekliği
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //adımın harflerini tek tek aşağıya yazma kodu
/*string ad = "merve";

for (int i = 0; i < ad.Length; i++)
{
    Console.WriteLine(ad[i]);
} */

/*  Console.Write("Kaç adet ürün gireceksiniz? ");
int urunSayisi = Convert.ToInt32(Console.ReadLine());

string[] urunler = new string[urunSayisi]; 
decimal[] fiyatlar = new decimal[urunSayisi];

for (int i = 0; i < urunSayisi; i++)
{
    Console.Write($"Ürün {i + 1} adı: ");
    urunler[i] = Console.ReadLine();

    Console.Write($"Ürün {i + 1} fiyatı: ");
    fiyatlar[i] = Convert.ToDecimal(Console.ReadLine());
}

Console.WriteLine("Ürünler ve Fiyatları:");

for (int i = 0; i < urunSayisi; i++)
{
    Console.WriteLine($"{urunler[i]} - {fiyatlar[i]}");
}
Console.ReadLine(); */
}
}
}
