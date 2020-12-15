using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class RGBToHex
    {
        public static void convert(int r,int g,int b)
        {
            string rhex = Convert.ToString(r,16);
            string ghex = Convert.ToString(g, 16);
            string bhex = Convert.ToString(b, 16);
            Console.WriteLine("#{0}{1}{2}",rhex,ghex,bhex);
        }

        public static void convertHexToInt(string hex)
        {
            int i = Convert.ToInt32(hex,16);
            Console.WriteLine(i);
        }
    }
}
