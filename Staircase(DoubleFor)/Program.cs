using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase_DoubleFor_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = $"#";
            string sps = $" ";

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(sps);
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
