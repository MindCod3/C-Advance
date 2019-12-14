using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);


            Queue<string> songsList = new Queue<string>(songs);

            while (songsList.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    songsList.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsList));
                }
                else if (command.StartsWith("Add"))
                {
                    string song = command.Substring(4);
                    if (!songsList.Contains(song))
                    {
                        songsList.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                   
                }
            }

            Console.WriteLine("No more songs!");

        }
    }
}
