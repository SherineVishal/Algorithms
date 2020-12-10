using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Algorithms
{
    class MergeIntervals
    {
        public static void merge(List<Interval> intervals)
        {
            Stack<Interval> stack = new Stack<Interval>();
            intervals.Sort((x, y) => x.start.CompareTo(y.start));
            foreach(var item in intervals)
            {
                if (stack.Count == 0)
                    stack.Push(item);
                else
                {
                    if (item.start < stack.Peek().end)
                    {
                        Interval newInterval = new Interval(stack.Peek().start,item.end);
                        stack.Pop();
                        stack.Push(newInterval);
                    }
                    else
                        stack.Push(item);
                }
            }
            while (stack.Count > 0)
            {
                Interval tempInterval = stack.Pop();
                Console.WriteLine("{0},{1}",tempInterval.start,tempInterval.end );
            }
        }
    }
}
