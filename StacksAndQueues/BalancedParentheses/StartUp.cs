using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> brackets = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    brackets.Push(input[i]);
                }
                else if (brackets.Count==0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    switch (input[i])
                    {
                        case '}':
                            if (!(brackets.Pop() == '{'))
                            {
                                Print();
                                return;
                            }
                            break;
                        case ']':
                            if (!(brackets.Pop() == '['))
                            {
                                Print();
                                return;
                            }
                            break;
                        case ')':
                            if (!(brackets.Pop() == '('))
                            {
                                Print();
                                return;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine("YES");
        }

        public static void Print()
        {
            Console.WriteLine("NO");
        }
    }
}
