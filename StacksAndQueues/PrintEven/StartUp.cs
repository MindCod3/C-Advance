using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> intNums = new Queue<int>();

            foreach (var num in nums)
            {
                intNums.Enqueue(num);
            }

            bool isFirstEvenNum = true;
            while (true)
            {
                int number = intNums.Dequeue();

                if (number % 2==0)
                {
                    if (!isFirstEvenNum)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(number);
                    isFirstEvenNum = false;
                }

                if (intNums.Count==0)
                {
                    break;
                }
            }
         
        }
    }
}
