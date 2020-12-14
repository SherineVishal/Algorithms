using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class MultiplicationTable
    {
        public static void print(int n,int m)
        {
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=m;j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
