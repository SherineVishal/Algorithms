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
            /*

            foreach (var item in exp)
            {
                if (item == ' ')
                    continue;
                if (item.Equals('+') || item.Equals('*'))
                {
                    if (operatorStack.Count == 0)
                        operatorStack.Push(item);
                    else if (hasHigherPresedence(item, operatorStack.Peek()))
                        operatorStack.Push(item);
                    else
                    {
                        int temp = operandsStack.Pop();
                        operandsStack.Push(item);
                        operandsStack.Push(temp);
                    }
                }
                else
                {
                    int operand1 = item - '0';
                    if (operandsStack.Count == 0)
                        operandsStack.Push(operand1);
                    else
                    {
                        char operatorSign = operatorStack.Pop();
                        int operand2 = operandsStack.Pop();                        

                        switch (operatorSign)
                        {
                            case '+':
                                result = operand1+ operand2;
                                break;
                            case '*':
                                result = operand1* operand2;
                                break;
                        }
                        operandsStack.Push(result);
                    }
                }
            }
            */

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
