using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimum
{
    class Program
    {
        static void Main()
        {
            int numberOfQueries = int.Parse(Console.ReadLine());

            Stack<int> collection = new Stack<int>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                int[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                switch (commands[0])
                {
                    case 1:
                        collection.Push(commands[1]);
                        break;
                    case 2:
                        if (collection.Count>0)
                        {
                            collection.Pop();
                        }
                        break;
                    case 3:
                        if (collection.Count>0)
                        {
                            Console.WriteLine(collection.Max());
                        }
                        break;
                    case 4:
                        if (collection.Count>0)
                        {
                            Console.WriteLine(collection.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",collection));
        }
    }
}
