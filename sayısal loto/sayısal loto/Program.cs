

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayısal_loto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adet = 0;
            int[] lotoSayi = new int[7];
            int[] sayilar = new int[7];
            int[] tutanSayilar = new int[7];
            Random r = new Random();
            int i = 0;
            int j = 0;
            Console.WriteLine("Kuponunuz için 7 adet sayı giriniz..:");
            for (j = 0; j < 7; j++)
            {
                sayilar[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Kuponunuz: ");
            foreach (int say in sayilar)
            {
                Console.Write(say + " ");
            }
            Console.WriteLine("\n*********\n");
            while (i < 7)
            {
                int sayi = r.Next(1, 50);
                if (lotoSayi.Contains(sayi))
                    continue;
                lotoSayi[i] = sayi;
                i++;
            }
            Array.Sort(lotoSayi);
            Console.Write("Loto: ");
            foreach (int sayi in lotoSayi)
                Console.Write(sayi + " ");
            Console.WriteLine("\n*********\n");

            for (i = 0; i < sayilar.Length; i++)
            {
                for (j = 0; j < sayilar.Length; j++)
                {
                    if (sayilar[i] == lotoSayi[j])
                    {
                        tutanSayilar[i] = sayilar[i];
                        adet++;

                    }
                }
            }
            Console.Write("Tutan Sayılar :");
            foreach (int tut in tutanSayilar)
            {
                if (tut != 0)
                {
                    Console.Write(" " + tut);

                }
            }
            Console.WriteLine("\n" + adet + " adet sayıyı tutturdunuz.");
            Console.ReadKey();





        }
    }
}
