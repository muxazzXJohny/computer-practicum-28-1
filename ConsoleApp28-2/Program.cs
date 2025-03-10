using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[9];
            RndOMass(omas);
            Elements(omas);
            Console.ReadLine();
        }
        public static void RndOMass(int[] omas)
        {
            Random random = new Random();
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = random.Next(-25, 25);
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }
        public static void Elements(int[] omas)
        {
            int count = 0;
            int count1 = 0;
            for (int i = 0; i < omas.Length; i++)
            {
                if ((omas[i] & 1) == 0)
                {
                    count++;
                }
                if ((omas[i] & 2) == 0)
                {
                    count1++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(count1);
        }
    }
}
