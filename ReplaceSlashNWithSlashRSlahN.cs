using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Algorithms
{
    class ReplaceSlashNWithSlashRSlahN
    {
        public static void readAndWrite()
        {

            //Method 1
            //StreamReader reader = new StreamReader(@"C:\Users\sheri\OneDrive\Desktop\tobuy.txt");
            //StreamWriter writer = new StreamWriter(@"C:\Users\sheri\OneDrive\Desktop\tobuyCopy.txt");

            //string currentLine;

            //while(!reader.EndOfStream)
            //{
            //    currentLine = reader.ReadLine();
            //    writer.Write(currentLine+"\r\n");
            //}

            //reader.Close();
            //writer.Close();

            //Method 2;

            //string str = "The world is beautiful.\n God is good.\n Read the lines.\n";
            //Console.WriteLine(str);
            //str = str.Replace("\n", "\r\n");

            //Console.WriteLine(str);

            //Method 3:

            char[] input = new char[] { 'a', 'b','\n', 'c', 'd', 'e','\n', 'f', 'g','\n', 'h','\n' };
            char[] output = new char[4];

            for(int i=0;i<input.Length;)
            {
                for(int j=0;j<output.Length && i<input.Length;j++)
                {
                    if(!(input[i]=='\n'))
                    {
                        output[j] = input[i++];
                    }
                    else
                    {
                        output[j++] = '\r';
                        if (j < output.Length)
                            output[j] = input[i++];
                    }
                }
                foreach (var item in output)
                    Console.Write(item);
                Console.WriteLine();
                Console.WriteLine();
            }
           
        }
    }
}
