using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Queue<string> names = new Queue<string>(input);

            int passNtimes = int.Parse(Console.ReadLine());

            while (names.Count > 1)
            {
                for (int i = 0; i < passNtimes - 1; i++)
                {
                    string name = names.Dequeue();
                    names.Enqueue(name);
                }
                Console.WriteLine("Removed " + names.Dequeue());
            }

            Console.WriteLine("Last is " + names.Peek());
        }
    }
}
