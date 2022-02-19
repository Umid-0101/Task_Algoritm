using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._10Ile100arasindakiTamKvadratlariTapanProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kv, eded = 4;
            while ((eded * eded) <= 1000)
            {
                kv = eded * eded;
                Console.WriteLine(kv);
                eded++;
            }
            Console.ReadLine();
        }
    }
}
//using System;
//namespace dmg
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 4;
//            for (i = 4; i <= 1000; i++)
//            {
//                if ((i * i) <= 1000)
//                {
//                    Console.WriteLine(Math.Pow(i, 2));
//                }
//            }
//            Console.ReadLine();
//        }
//    }
//}
