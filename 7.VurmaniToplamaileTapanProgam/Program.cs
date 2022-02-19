using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.VurmaniToplamaileTapanProgam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2,sayac =0;
            Console.Write("1-ci ededi girin: ");
            sayi1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2-ci ededi girin: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1>=sayi2)
            {
                while(sayi2>0)
                {
                    sayac = sayac + sayi1;
                    sayi2--;
                } 
            }
            else
            {
                while (sayi1>0)
                {
                    sayac=sayac + sayi2;
                    sayi1--;
                }
            }
            Console.WriteLine(sayac);
            Console.ReadLine();
        }
    }
}
