using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindMissingParenthesis
    {
        public static void findMissingParenthesis(string exp)
        {
            Stack<char> paranthesisStack = new Stack<char>();
            int missingOpenParenthesis = 0, missingCloseParenthesis = 0;
            for (int i=0;i<exp.Length;i++)
            {
                if (exp[i].Equals('('))
                    paranthesisStack.Push('(');
                if (exp[i].Equals(')'))
                {
                    if (paranthesisStack.Count == 0)
                        missingOpenParenthesis++;
                    else
                        paranthesisStack.Pop();
                }
            }

            while(paranthesisStack.Count!=0)
            {
                missingCloseParenthesis++;
                paranthesisStack.Pop();
            }

            Console.WriteLine("No. of missing open parenthesis: {0}", missingOpenParenthesis);
            Console.WriteLine("No. of missing close parenthesis: {0}", missingCloseParenthesis);

        }
    }
}
