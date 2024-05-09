using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            const double pi = 3.14;
            double r;

            Console.WriteLine("yarıcap giriniz:");
            r=Convert.ToInt32(Console.ReadLine());


            double  alan;
            alan = pi * r * r;
           Console.WriteLine("yarıcap: {0} \nalan: {1}",r,alan);



                




        }
    }
}
