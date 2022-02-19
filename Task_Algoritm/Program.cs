using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Algoritm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] deyisenler = new string[] { "cay", "caydanlik", "su", "seker", "tup", "bardak" };
            string caydanlik = "su";
            string ates = "caydanlik" + "su";
            bool qaynamisdir = true;
            bool sekerliiciyor = true;
            bool cayikarisdir = true;
            bool cayiic = true;
            bool gozle = true;
            if (qaynamisdir == true)
            {
                string bardak1 = "bardak" + "su";
                string bardak2 = bardak1 + "cay";
                if (sekerliiciyor == true)
                {
                    string bardak = bardak2 + "seker";
                    cayikarisdir = true;
                    cayiic = true;
                }
                else
                {
                    cayiic = true;
                }
            }
            else
            {
                gozle = true;
            }
        }
    }
}
