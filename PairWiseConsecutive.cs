using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class PairWiseConsecutive
    {
        public static void pairWiseConsecutive(Stack<int> stack)
        {
            
            if (stack.Count == 0)
                return;

            int flag = 1;
            Stack<int> tempStack = new Stack<int>();
            int temp;

            if (stack.Count % 2 == 1)
                tempStack.Push(stack.Pop());
            
                while (stack.Count > 0)
                {
                    temp = stack.Pop();
                    if (Math.Abs(temp - stack.Peek()) == 1)
                    {
                        tempStack.Push(temp);
                        tempStack.Push(stack.Pop());
                    }
                    else
                    {
                        tempStack.Push(temp);
                        flag = 0;
                        break;
                    }
                }

            if (flag == 0)
                Console.WriteLine("No");
            else
                 Console.WriteLine("yes");
            
            while (tempStack.Count > 0)
                stack.Push(tempStack.Pop());

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());

        }
    }
}
