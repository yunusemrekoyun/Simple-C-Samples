using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Dizideki eleman sayısını girin :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];
            int eleman = n;
            int tekrarSayisi = 0;
            int geciciTekrar = 1;
            for (int i = 0; i < n; i++)

            {
                Console.WriteLine("{0}. elemanı girin", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                if (dizi[i] == dizi[i + 1])
                    geciciTekrar++;


                if (i == (dizi.Length - 2) || dizi[i] != dizi[i + 1])
                {
                    if (geciciTekrar > tekrarSayisi)
                    {
                        tekrarSayisi = geciciTekrar;
                        eleman = dizi[i];
                    }


                }
            }



            Console.WriteLine(eleman + " elemanı en çok tekrarlanmıştır. Ve bu eleman " + tekrarSayisi + "  kez tekrar etmiştir.");
            Console.ReadLine();

        }
    }
}


