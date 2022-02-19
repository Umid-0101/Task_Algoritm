using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolmeniCixmaileYazanProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bolunen, bolen;
            float i=0;
            Console.Write("Boluneni qeyd edin: ");
            bolunen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Boleni daxil edin: ");
            bolen = Convert.ToInt32(Console.ReadLine());
            for (i = 1; bolunen>=bolen; i++)
            {
                bolunen = bolunen - bolen;
            }
            Console.Write("Netice :" + i);
            Console.ReadLine();
        }
    }
}
