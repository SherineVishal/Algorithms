using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class PrimeNumbers
    {
        public static void print(int n)
        {
            for(int i=2;i<=n;i++)
            {
                bool prime = true;
                for (int j = 2; j < i-1; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime == true)
                    Console.WriteLine(i);
            }
        }
    }
}
