using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 0)
            {
                Console.WriteLine("Asaldir");
            }
            else
            {
                Console.WriteLine("Asal degildir");
            }
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}