using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class EquilibriumIndex
    {
        public static void findEquilibriumIndex(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Array is of length 0");
                return;
            }

            int rSum = 0;
            int lSum = 0;
            foreach (var item in arr)
                rSum += item;
            for (int i = 0; i < arr.Length; i++)
            {
                rSum -= arr[i];
                if(rSum==lSum)
                {
                    Console.WriteLine("Equilibrium Index : {0}",i);
                    return;
                }
                lSum += arr[i];
            }

        }
    }
}
