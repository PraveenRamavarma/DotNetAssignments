using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swtich
{
    internal class StarPattern
    {
        static void Main3(string[] args)
        {
            for (int index = 1; index <= 6; ++index)
            {
                for (int index1 = 1; index1 <= index; ++index1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
