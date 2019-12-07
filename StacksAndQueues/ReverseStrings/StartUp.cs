using System;
using System.Collections;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> reverseStringOrder = new Stack<char>();

            foreach (var letter in input)
            {
                reverseStringOrder.Push(letter);
            }

            foreach (var letter in reverseStringOrder)
            {
                Console.Write(letter);
            }

        }
    }
}
