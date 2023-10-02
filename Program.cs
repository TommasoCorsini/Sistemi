using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversioniSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] b = { true, false, true, false };
            int[] dp = { 10, 10, 10, 10 };
            Console.WriteLine(Convert_Binario_To_Decimale(b));
            Console.WriteLine(Convert_Decimale_Puntato_To_Decimale(dp));
            Console.WriteLine();
            Console.ReadLine();
        }

        static int Convert_Binario_To_Decimale(bool[] b)
        {
            int numero = 0;
            int j = 0;
            for(int i = 0; i < b.Length; i++)
            {
                if (b[i])
                {
                    numero = numero + (int)(Math.Pow(2,j));
                }
            }
            return numero;
        }
        static int Convert_Decimale_Puntato_To_Decimale(int[] dp)
        {
            int dec = 0;
            int j = dp.Length - 1;
            for (int i = 0; i < dp.Length; i++)
            {
                dec = dec + (int)(Math.Pow(256, j));
                j--;
            }
            Console.Write(dec);
            return dec;
        }
    }
}
