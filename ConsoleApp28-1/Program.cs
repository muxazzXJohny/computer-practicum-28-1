using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[14];
            VvodMass(omas);
            Elements(omas);
            Console.ReadKey();
        }
        public static void VvodMass(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.Write($"omas[{i}]=");
                omas[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void Elements(int[] omas)
        {
            int n = 0;
            foreach (int element in omas)
            {
                if ((element & 1) == 0)
                {
                    n++;
                }
            }
            Console.WriteLine($"Количество чётных елементов={n}");
        }
    }
}

