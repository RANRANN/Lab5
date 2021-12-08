using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            for (int i=0;i<7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            double S = 0;
            for (int i = 0; i < 7; i++)
            {
                
                S += array[i];
                Console.Write("{0,3 }", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine(S / 7);
            Console.ReadKey();


        }
    }
}
