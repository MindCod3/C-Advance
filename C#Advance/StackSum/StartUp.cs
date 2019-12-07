using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command;

            Stack<int> numbersCollection = new Stack<int>(numbers);

            while ((command=Console.ReadLine()).ToLower()!="end")
            {
                string[] commandArgs = command.Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (commandArgs[0].ToLower())
                {
                    case "add":
                        numbersCollection.Push(int.Parse(commandArgs[1]));
                        numbersCollection.Push(int.Parse(commandArgs[2]));
                        break;
                    case "remove":
                        int removeNnums = int.Parse(commandArgs[1]);
                        if (numbersCollection.Count < removeNnums)
                        {
                            continue;
                        }
                        for (int i = 0; i < removeNnums; i++)
                        {
                            numbersCollection.Pop();
                        }
                        break;
                }
            }

            Console.WriteLine("Sum: "+numbersCollection.Sum());
        }
    }
}
