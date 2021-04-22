using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Factorial
    {
        public static int factorial(int n)
        {
            //Method 1
            //int fact = 1;
            //for (int i = 2; i <= n; i++)
            //    fact *= i;
            //return fact;

            //Method 2
            if (n == 1)
                return 1;
            return n * factorial(n - 1);
        }
    }
}
