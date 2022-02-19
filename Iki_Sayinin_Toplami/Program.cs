using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki_Sayinin_Toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("1-ci ededi daxil edin =");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-ci ededi daxil edin =");
            c = Convert.ToInt32(Console.ReadLine());
            a = b + c;
            Console.WriteLine("Cem: " + a + " - Edir");
            Console.ReadLine();
        }
    }
}
