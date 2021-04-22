using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class MergeNegativePositive
    {
        public static int[] mergeNegativePositive(int[] arr1,int[] arr2)
        {
            int i = 0,j=0,start=0;
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            int end = len1 + len2 - 1;

            int[] mergedArray = new int[len1+len2];

            while(i<len1)
            {
                if (arr1[i] < 0)
                    mergedArray[start++] = arr1[i];
                else
                    mergedArray[end--] = arr1[i];
                i++;
            }
            while(j<len2)
            {
                if (arr2[j] < 0)
                    mergedArray[start++] = arr2[j];
                else
                    mergedArray[end--] = arr2[j];
                j++;
            }

            return mergedArray;
        }
    }
}
