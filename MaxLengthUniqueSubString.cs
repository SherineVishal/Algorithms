using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class MaxLengthUniqueSubString
    {
        public static int findMax(string str)
        {
            //        int len = str.Length;
            //        int res = 0;

            //        for(int i=0;i<len;i++)
            //        {
            //            for(int j=i;j<len;j++)
            //            {
            //                if(isDistinct(str,i,j))
            //                {
            //                    res = Math.Max(res, j - i);
            //                }
            //            }
            //        }
            //        return res;
            //    }

            //    public static bool isDistinct(string str,int i,int j)
            //    {
            //        bool[] visited = new bool[26];
            //        for(int k=i;k<j;k++)
            //        {
            //            if (visited[str[k] - 'a'])
            //                return false;
            //            visited[str[k] - 'a'] = true;
            //        }
            //        return true;


            //Method 2
            //int res = 0;
            //for(int i = 0; i < str.Length;i++)
            //{
            //    bool[] visited = new bool[256];

            //    for(int j=i;j<str.Length;j++)
            //    {
            //        if (visited[str[j]] == true)
            //                break;
            //        else
            //        {
            //            res = Math.Max(res,j-i+1);
            //            visited[str[j]] = true;
            //        }
            //    }

            //    visited[str[i]] = false;
            //}
            //return res;


            //Method 2
            int res=0;
            Dictionary<char, int> seen = new Dictionary<char, int>();

            int start = 0;
            for (int end = 0; end < str.Length;end++)
            {
                if(seen.ContainsKey(str[end]))
                {
                    start = Math.Max(start, (seen[str[end]] + 1));
                }
                else
                {
                    seen[str[end]] = end;
                    res = Math.Max(res,end-start+1);
                }
            }

            return res;
        }

        
        
    }
}
