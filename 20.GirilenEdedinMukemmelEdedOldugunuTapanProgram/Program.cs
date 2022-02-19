using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.GirilenEdedinMukemmelEdedOldugunuTapanProgram
{
    internal class Program
    {
        //ozunden basqa oz bolenleri cemine = olan edede mukemmel eded deyilir. mes 6=1+2+3
        static void Main(string[] args)
        {
            int eded;
            int sayac = 2;
            int top = 1;
            Console.Write("Ededi daxil edin = ");
            eded = Convert.ToInt32(Console.ReadLine());
        dnz:
            if (eded % sayac == 0)
            {
                top = top + sayac;
                sayac++;
            }
            else
            {
                sayac++;
            }
            if (sayac > eded / 2)
            {
                if (top == eded)
                    Console.WriteLine("Mükemmeldir");
                else
                    Console.WriteLine("Mükemmel degildir");
            }
            else
            {
                goto dnz;
            }
            Console.ReadLine();
        }
    }
}
