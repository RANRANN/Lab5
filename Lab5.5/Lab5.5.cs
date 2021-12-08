using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение N ");
            int n = Convert.ToInt32(Console.Read());
            int[,] array = new int[n, n];
            int i = 0;
            int j = 0;

            Console.WriteLine("{0,2}",array[i,j]);
            Console.ReadKey();
        }
    }
}
