using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swtich
{
    internal class Loops
    {
        static void Main2(string[] args)
        {
            for (int index = 0; index < 10; index++)
            {
                Console.Write(index + " ");
            }
            Console.WriteLine("========================================");
            int doindex = 0;
            do
            {
                Console.Write(doindex + " ");
                doindex++;
            } while (doindex < 10);

            Console.WriteLine("========================================");
            int whileindex = 0;
            while (whileindex < 10)
            {
                Console.Write(whileindex + " ");
                whileindex++;
            }
        }
    }
}
