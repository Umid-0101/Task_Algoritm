using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogumTarihineGoreYas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dyili, yil, yas;
            Console.Write("Dogum Ilinizi Girin: ");
            dyili = Convert.ToInt32(Console.ReadLine());
            yil=DateTime.Now.Year;
            yas = yil - dyili;
            Console.WriteLine(yas);
            Console.ReadLine();
        }
    }
}
