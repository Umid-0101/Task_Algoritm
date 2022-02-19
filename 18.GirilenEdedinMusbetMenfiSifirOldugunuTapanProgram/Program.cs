using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.GirilenEdedinMusbetMenfiSifirOldugunuTapanProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eded;
            Console.Write("Ededi daxil edin : ");
            eded = Convert.ToInt32(Console.ReadLine());
            if (eded>0)
            {
                Console.WriteLine("Eded msubetdir");
            }
            else if(eded==0)
            {
                Console.WriteLine("Eded 0-dir");
            }
            else
            {
                Console.WriteLine("Eded menfidir");
            }
            Console.ReadLine();
        }
    }
}
