using System;
using System.Collections.Generic;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;

            Queue<string> clients = new Queue<string>();

            while ((input=Console.ReadLine())!="End")
            {
                if (input=="Paid")
                {
                    while (clients.Count!=0)
                    {
                        Console.WriteLine(clients.Dequeue());
                    }
                    continue;
                }
                clients.Enqueue(input);
            }

            Console.WriteLine(clients.Count+" people remaining.");
        }
    }
}
