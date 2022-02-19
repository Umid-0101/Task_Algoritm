using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1den100ekadarededlerinkubu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int toplam = 0;
            for (i = 1; i <= 101; i++)
            {
                toplam = toplam + (i * i * i);
            }
            Console.Write("1-100 arası toplam = " + toplam);
            Console.ReadLine();

        }
    }
}
