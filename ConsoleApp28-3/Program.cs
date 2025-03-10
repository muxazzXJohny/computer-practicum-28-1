using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 1, 3, 6, 7, 10, 12, 9, 24 };
        }
        public static void Elements(int[] omas)
        {
            int maxelement = omas[0];
            int maxindex = 0;
            int a = 0;
            for (int i = 0; i < omas.Length; i++)
            {
                if (maxelement < omas[i])
                {
                    maxindex = i;
                }
            }
            a = omas[0];
            omas[0] = omas[maxindex];
            omas[maxindex] = a;
        }
    }
}
    

