using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.GirilenSayinin5inQuvvetiOlubOlmadiginiTapanProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eded, i = 0;
            Console.WriteLine("Ədədi daxil edin: ");
            eded = Convert.ToInt32(Console.ReadLine());

        dvr: if (eded % 5 == 0)
            {
                eded = eded / 5;
                goto dvr;
            }
            else if (eded == 1)
            {
                Console.WriteLine("Ədəd 5 in" + i + "dərəcədən qüvvətidir:");
            }
            else
            {
                Console.WriteLine("Ədəd 5 in quvveti deyil!");
            }
        }
    }
}
