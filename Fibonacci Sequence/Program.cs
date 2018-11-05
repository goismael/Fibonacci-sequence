using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] FibNum = new int[21];
            FibNum[0] = 0;
            FibNum[1] = 1;
            for (int counter = 2; counter <= 20; counter++)
            {
                FibNum[counter] = FibNum[counter - 2] + FibNum[counter - 1];
                Console.WriteLine(FibNum[counter]);
            }
            Console.Read();
        }
        
    }
}
