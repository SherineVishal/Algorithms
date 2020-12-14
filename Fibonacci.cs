using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Fibonacci
    {
        public static int fiboWithoutRec(int n)
        {
            if (n == 0 || n == 1)
                return n;

            int[] fiboList = new int[n];
            fiboList[0] = 0;
            fiboList[1] = 1;
            for (int i = 2; i < n; i++)
                fiboList[i] = fiboList[i - 1] + fiboList[i - 2];
            return fiboList[n - 1];
        }

        public static int fiboWithRec(int n)
        {
            return (n <= 1 ? n : fiboWithRec(n - 1) + fiboWithRec(n - 2));
        }

        public static int fibonacci(int n)
        {
            return (n <= 1 ? n : fibonacci(n - 1) + fibonacci(n - 2));
        }
    }
    
}
