using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class EvaluateExpression
    {
        public static void evaluate(string exp)
        {
            Stack<int> operandsStack = new Stack<int>();
            Stack<char> operatorStack = new Stack<char>();
            
            foreach(var token in exp)
            {
                if (token == ' ')
                    continue;
                if (token >= '0' && token <= '9')
                {
                    int val = token - '0';
                    operandsStack.Push(val);
                }
                else if (token == '+' || token == '*')
                {
                    while (operatorStack.Count > 0 && isPrecedence(token, operatorStack.Peek()))
                        operandsStack.Push(OpApply(operatorStack.Pop(), operandsStack.Pop(), operandsStack.Pop()));
                    operatorStack.Push(token);
                }
            }

            while(operatorStack.Count>0)
                operandsStack.Push(OpApply(operatorStack.Pop(), operandsStack.Pop(), operandsStack.Pop()));
            Console.WriteLine(operandsStack.Pop());
        }

        public static bool isPrecedence(char token,char operator2)
        {
            if (token.Equals('+') && operator2.Equals('*'))
                return true;
            else
                return false;
        }

        public static int OpApply(char op,int val1,int val2)
        {
            switch(op)
            {
                case '*': return (val1 * val2);
                case '+': return (val1 + val2);
            }
            return 0;
        }
    }
}
