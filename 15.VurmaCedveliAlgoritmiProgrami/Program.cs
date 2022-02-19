using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.VurmaCedveliAlgoritmiProgrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    result = i * j;
                    Console.WriteLine(i + "*" + j + "=" + result);
                }
                Console.WriteLine("---------------");
            }
            Console.ReadLine();
        }
    }
}