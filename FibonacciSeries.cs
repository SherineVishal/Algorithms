using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FibonacciSeries
    {
        public static int Fibonacci(int n)

        {

            //Method 1
            //int[] arr = new int[n];

            //arr[0] = 0;
            //arr[1] = 1;

            //for(int i=2;i<n;i++)
            //{
            //    arr[i] = arr[i - 1] + arr[i - 2];
            //}

            //return arr;

            //Method 2

            if (n == 1 || n == 0)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);


        }
    }
}
