using System;
namespace dmg
{
    class Program
    {
        static void Main(string[] args)
        {
            //tam anlamadim suali, copy edib yapisdiridim
            int sayi, bas;
            int top = 0;
            Console.Write("Bir sayı giriniz = ");
            sayi = Convert.ToInt32(Console.ReadLine());
        dnz:
            bas = sayi % 10;
            top = top + (bas * bas * bas);
            if (sayi < 10)
            {
                top = top + (sayi * sayi * sayi);
                goto dnz;
            }
            if (top == sayi)
            {
                Console.WriteLine("Eşit");
            }
            else
            {
                Console.WriteLine("Eşit değil");
            }
            Console.ReadLine();
        }
    }
}