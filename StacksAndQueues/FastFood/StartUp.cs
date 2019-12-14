using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Queue<int> ordersFromClients = new Queue<int>(orders);

            Console.WriteLine(ordersFromClients.Max());

            while (ordersFromClients.Count>0)
            {
                if (ordersFromClients.Peek()<=quantityOfFood)
                {
                    quantityOfFood -= ordersFromClients.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (ordersFromClients.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(" ",ordersFromClients));
            }
        }
    }
}
