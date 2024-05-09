using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, kalan;
            string x = "";
            
            Console.Write("Sayi Giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            while (sayi1 != 0)
            {
                kalan = sayi1 % 2;
                sayi1 = sayi1 / 2;

                x = kalan.ToString() + x;
               
            }
            Console.WriteLine("{0}", x);

            Console.ReadKey();
        }
    }
}