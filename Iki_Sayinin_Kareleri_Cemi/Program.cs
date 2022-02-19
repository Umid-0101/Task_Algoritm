using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki_Sayinin_Kareleri_Cemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, top;
            Console.Write("1-ci ededi girin =");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-ci ededi girin = ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            top = (int)Math.Pow(sayi1,2) + (int)Math.Pow(sayi2, 2);
            //top = (sayi1 * sayi1) + (sayi2 * sayi2);
            Console.WriteLine("Kvadratlar Cemi: " + top + "-Edir");
            Console.ReadLine();
        }
    }
}
