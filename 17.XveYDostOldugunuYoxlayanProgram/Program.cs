using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.XveYDostOldugunuYoxlayanProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, i;
            int xcarpan = 0, ycarpan = 0;
            Console.Write("1.sayıyı giriniz = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayıyı giriniz = ");
            y = Convert.ToInt32(Console.ReadLine());
            i = (x - (x % 2)) / 2;
            while (i > 0)
            {
                if (x % i == 0)
                    xcarpan = xcarpan + i;
                i--;
            }
            i = 1;
            while (i < y)
            {
                if (y % i == 0)
                    ycarpan = ycarpan + i;
                i++;
            }
            if (xcarpan == y && ycarpan == x)
            {
                Console.WriteLine(x + " ile " + y + "dost sayilardir");
            }
            else
            {
                Console.WriteLine(x + " ile " + y + " dost degildir");
            }
            Console.ReadLine();
        

    }
}
}
