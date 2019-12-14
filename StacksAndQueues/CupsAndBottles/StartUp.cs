using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine()
                          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse).ToArray();

            int[] bottles = Console.ReadLine()
                          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse).ToArray();

            Queue<int> cupsCollection = new Queue<int>(cups);
            Stack<int> bottlesCollection = new Stack<int>(bottles);

            int waste = 0;
            int addtitionalBottle = 0;

            while (cupsCollection.Count > 0 && bottlesCollection.Count > 0)
            {
                int bottle = bottlesCollection.Pop() + addtitionalBottle;

                if (bottle - cupsCollection.Peek() >= 0)
                {
                    waste += bottle - cupsCollection.Dequeue();
                    addtitionalBottle = 0;
                }
                else
                {
                    addtitionalBottle = bottle;
                }
            }

            if (cupsCollection.Count == 0)
            {
                if (bottlesCollection.Count > 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(" ", bottlesCollection)}");
                }
                Console.WriteLine($"Wasted litters of water: {waste}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsCollection)}");
                Console.WriteLine($"Wasted litters of water: {waste}");
            }

        }
    }
}
