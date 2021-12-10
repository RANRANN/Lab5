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
            Console.Write("Введите значение N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i+j)%2==0)
                    {
                        Console.Write("{0}", 1);
                    }
                    else
                    {
                        Console.Write("{0}", 0);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
