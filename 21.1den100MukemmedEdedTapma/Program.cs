using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._1den100MukemmedEdedTapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int top = 0;
            int y = 0;
            for (i = 0; i <= 98; i++)
            {
                top = top + (2 + i);
            }
            for (i = 1; i <= (top / 2); i++)
            {
                if ((top % i) == 0)
                {
                    y = y + i;
                }
            }
            if (top == y)
            {
                Console.WriteLine("Mükemmel");
            }
            else
            {
                Console.WriteLine("Mükemmel değildir");
            }
            Console.ReadLine();
        }
    }
}
