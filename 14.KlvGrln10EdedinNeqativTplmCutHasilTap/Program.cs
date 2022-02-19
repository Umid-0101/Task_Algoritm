using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.KlvGrln10EdedinNeqativTplmCutHasilTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eded, menfi = 0, cut = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write(i+"-ci ededi daxil edin: ");
                eded = Convert.ToInt32(Console.ReadLine());
                if (eded<0)
                {
                    eded = menfi + eded;
                    //Console.WriteLine(menfi);
                }
                else if (eded%2==0)
                {
                    eded = cut + eded;
                    //Console.WriteLine(cut);
                }
                else
                {
                    eded = 0;
                }
                
            }
            Console.WriteLine("test");
            Console.ReadLine();

        }
    }
}
