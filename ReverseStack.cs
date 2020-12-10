using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class ReverseStack
    {
        public static void reverse(Stack<int> stack)
        {
            
            int temp;
            Stack<int> tempStack = new Stack<int>();
            int count = stack.Count;
            while (count > 0)
            {
                temp = stack.Pop();
                for (int i = 0; i < count-1; i++)
                    tempStack.Push(stack.Pop());
                stack.Push(temp);
                while (tempStack.Count > 0)
                    stack.Push(tempStack.Pop());
                count--;
            }

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
        }
    }
}
