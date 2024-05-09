using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_1
{
    
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("1. Sayiyi giriniz: ");
            int sayi1 =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sayiyi giriniz: ");
            int sayi2= Convert.ToInt32(Console.ReadLine());
                int ebob = 0;

                for (int i = 1; i < sayi1; i++)
                {
                    if (sayi1 % i == 0 && sayi2 % i == 0)
                    {
                        ebob = i;
                    }
                }
                Console.WriteLine("Ebob = {0}",ebob);
                Console.ReadLine();

            }
        }
    }



    

