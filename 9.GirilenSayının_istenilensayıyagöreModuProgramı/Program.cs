using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.GirilenSayının_istenilensayıyagöreModuProgramı
{
    //qaligi tapmaq teleb olunur
    internal class Program
    {
        static void Main(string[] args)
        {
            int eded1, eded2, qaliq=0 ;
            Console.Write("1-ci ededi daxil edin: ");
            eded1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-ci ededi daxil edin: ");
            eded2 = Convert.ToInt32(Console.ReadLine());
            while (eded1 >= eded2)
            {
                eded1 = eded1 - eded2;
            }
            Console.WriteLine("Qaliq: "+eded1);
            Console.ReadLine();
        }
    }
}
