using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
              
            1.Find the element that appears once in a sorted array where all other elements appear twice one after another. 
            Find that element in 0(logn) complexity. 
             
            Input: arr[] = {1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8} 
            Output: 4
            
            */
            
            
            
            int[] arr = { 1,1, 3, 3, 4,5, 5, 7, 7, 8,8}; 
            FindSingleInSortedArray.findSingle(arr,0,arr.Length-1);

            
        }
    }
}
