using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class PrintSpiral
    {
        public static void print(int[,] arr)
        {

            int left = 0;
            int right = arr.GetLength(1);
            int top = 0;
            int down = arr.GetLength(0);

            int tCount = right * down;
            int count = 0;  
            int i;

            while(top<down && left<right)
            {
                    for (i = left; i < right; i++)
                    {
                        Console.WriteLine(arr[top, i]);
                        count++;
                    }
                
                top++;
                
                
                    for (i = top; i < down; i++)
                    {
                        Console.WriteLine(arr[i, right - 1]);
                        count++;
                    }
                    right--;
                
                if (top < down)
                {
                    for (i = right - 1; i >= left; i--)
                    {
                        Console.WriteLine(arr[down - 1, i]);
                        count++;
                    }
                    down--;
                }
                if (left < right)
                {
                    for (i = down - 1; i >= top; i--)
                    {
                        Console.WriteLine(arr[i, left]);
                        count++;
                    }
                    left++;
                }
            }
        }
    }
}
