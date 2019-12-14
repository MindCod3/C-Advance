using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOper
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] numConditions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[] nums = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray();

            Queue<int> numbersCollection = new Queue<int>();

            for (int i = 0; i < numConditions[0]; i++)
            {
                numbersCollection.Enqueue(nums[i]);
            }

            for (int i = 0; i < numConditions[1]; i++)
            {
                numbersCollection.Dequeue();
            }

            if (numbersCollection.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (numbersCollection.Contains(numConditions[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbersCollection.Min());
            }
        }
    }
}
