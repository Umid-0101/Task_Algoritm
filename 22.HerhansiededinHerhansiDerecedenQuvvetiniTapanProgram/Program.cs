using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.HerhansiededinHerhansiDerecedenQuvvetiniTapanProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int us;
            int top = 1;
            Console.Write("Sayıyı giriniz = ");
            sayi =
           Convert.ToInt32(Console.ReadLine());
            Console.Write("Ussu giriniz = ");
            us =
           Convert.ToInt32(Console.ReadLine());
            while (us > 0)
            {
                top = top * sayi;
                us--;
            }
            Console.Write("Sonuç = " + top);
            Console.ReadLine();
        }
    }
}
