using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class PrintParanthesis
    {
        public static void printParanthesis(char[] str,int n)
        {
            if (n > 0)
                _PrintParanthesis(str, 0, n, 0, 0);
            return;

        }

        public static void _PrintParanthesis(char[] str,int pos,int n,int open,int close)
        {
            if (close == n)
            {
                for (int i = 0; i < str.Length; i++)
                    Console.Write(str[i]);
                Console.WriteLine();
                return;
            }
            else
            {
                if (close < open)
                {
                    str[pos] = '}';
                    _PrintParanthesis(str, pos+1, n, open, close+1);
                }
                if (open < n)
                {
                    str[pos] = '{';
                    _PrintParanthesis(str, pos + 1, n, open + 1, close);
                }
            }
        }
    }
}
