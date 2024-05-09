using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir kelime ya da sayi giriniz: ");
            string kelime = Console.ReadLine();
            string kelimenintersi = "";
            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                kelimenintersi += kelime[i];
            }
            if (kelimenintersi == kelime)
            {
                Console.WriteLine("Girilen Değer Palindromiktir.");
            }
            else
            {
                Console.WriteLine("Girilen Değer Palindromik değildir.");
            }
            Console.ReadLine();
        }
    }
}