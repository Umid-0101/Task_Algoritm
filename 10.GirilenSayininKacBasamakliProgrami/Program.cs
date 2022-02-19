using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.GirilenSayininKacBasamakliProgrami
{
    internal class Program
    {
        //girilen ededin nece reqemli olmasini tapan program
        static void Main(string[] args)
        {
            float sayi; int i=1;
            Console.Write("Ededi girin: ");
            sayi=Convert.ToInt32(Console.ReadLine());
            while (sayi>9)
            {
                sayi = sayi / 10;
                i++;
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
