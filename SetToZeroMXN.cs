using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class SetToZeroMXN
    {
        public static void modify(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);

            int[] firstRow = new int[col];
            for (int j = 0; j < col; j++)
                firstRow[j] = arr[0,j];

            int[] firstCol = new int[row];
            for (int i = 0; i < row; i++)
                firstCol[i] = arr[i, 0];

            for(int i=1;i<row;i++)
            {
                for (int j = 1; j < col; j++)
                {
                    if (arr[i, j] == 0)
                    {
                        arr[0, j] = 0;
                        arr[i, 0] = 0;
                    }
                }
            }

            for(int j=1;j<col;j++)
            {
                if (arr[0, j] == 0)
                {
                    for (int i = 1; i < row; i++)
                        arr[i, j] = 0;
                }
            }

            for(int i=1;i<row;i++)
            {
                if(arr[i,0]==0)
                {
                    for (int j = 1; j < col; j++)
                        arr[i, j] = 0;
                }
            }

            for (int j = 1; j < col; j++)
            {
                if (firstRow[j] == 0)
                {
                    for (int i = 1; i < row; i++)
                        arr[i, j] = 0;
                }

            }

            for (int i = 0; i < row; i++)
            {
                if (firstCol[i] == 0)
                {
                    for (int j = 1; j < col; j++)
                        arr[i, j] = 0;
                }
            }

            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.Write("{0} ",arr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
