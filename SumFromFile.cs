using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class SumFromFile
    {
        public static void findSum()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("C:\\Users\\sheri\\OneDrive\\Desktop\\values.txt");

                int sum = 0;
                foreach (var line in lines)
                    sum = sum + int.Parse(line);
                Console.WriteLine(sum);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
