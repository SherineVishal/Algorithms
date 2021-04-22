using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class MergeTwoSortedArray
    {
        public static int[] mergeTwoSortedArray(int[] arr1,int[] arr2)
        {
            //int len1 = arr1.Length;
            //int len2 = arr2.Length;
            //int[] mergedArray=new int[len1+len2];
            //int i = 0,j=0,k=0;
            //while(i<len1 && j<len2)
            //{
            //    if (arr1[i] < arr2[j])
            //    {
            //        mergedArray[k++] = arr1[i];
            //        i++;
            //    }
            //    else
            //    {
            //        mergedArray[k++] = arr2[j];
            //        j++;
            //    }
            //}

            //while(i<len1)
            //{
            //    mergedArray[k++] = arr1[i];
            //    i++;
            //}

            //while(j<len2)
            //{
            //    mergedArray[k++] = arr2[j];
            //    j++;
            //}

            //return mergedArray;

            int len1 = arr1.Length;
            int len2 = arr2.Length;

            int[] mergedArray = new int[len1 + len2];

            int i = 0, j = 0,k=0;
            while(i<len1 && j<len2)
            {
                if(arr1[i]<arr2[j])
                {
                    mergedArray[k++] = arr1[i++];
                }
                else
                {
                    mergedArray[k++] = arr2[j++];
                }
            }

            while (i < len1)
                mergedArray[k++] = arr1[i++];

            while (j < len2)
                mergedArray[k++] = arr2[j++];

            return mergedArray;
        }
    }
}
