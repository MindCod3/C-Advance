using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<int> bracketsIndex = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    bracketsIndex.Push(i);
                }
                else if (input[i]==')')
                {
                    Console.WriteLine(input.Substring(bracketsIndex.Peek(),i-bracketsIndex.Pop()+1));
                }
            }
        }
    }
}
