﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class OddNumbers
    {
        public static void print()
        {
            for(int i=1;i<100;i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
