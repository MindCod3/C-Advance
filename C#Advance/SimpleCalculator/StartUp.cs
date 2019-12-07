using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            Stack<string> numberToBeCalculated = new Stack<string>(input);

            int number;
            int sum=0;
            while (numberToBeCalculated.Count!=0)
            {
                number = int.Parse(numberToBeCalculated.Pop());

                if (numberToBeCalculated.Count == 0)
                {
                    sum += number;
                    break;
                }


                string symbol = numberToBeCalculated.Pop();
                if (symbol=="-")
                {
                    sum -= number;
                }
                else
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
     
        }
    }
}
