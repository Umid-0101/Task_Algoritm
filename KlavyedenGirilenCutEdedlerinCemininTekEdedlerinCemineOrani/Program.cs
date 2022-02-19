using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlavyedenGirilenCutEdedlerinCemininTekEdedlerinCemineOrani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float eded,cut=0,tek=0;
            float faiz;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i+".ededi daxl edin: ");
                eded = Convert.ToInt32(Console.ReadLine());
                if (eded%2==0)
                {
                    cut = cut + eded;
                }
                else
                {
                    tek=tek + eded;
                }
            }
            faiz=(cut/tek)*100;
            Console.WriteLine(faiz);
            Console.ReadLine();
        }
    }
}

