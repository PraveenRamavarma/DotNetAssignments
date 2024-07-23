using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swtich
{
    internal class FunctionTest
    {
        public static int FindMax(int a , int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This is the maximum number");
            Console.WriteLine(FindMax(10, 8, 5));
        }
    }
}
