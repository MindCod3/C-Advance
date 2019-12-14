using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());

            int sizeOfGunBarrel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray();

            int intelligence = int.Parse(Console.ReadLine());


            Queue<int> locksCollection = new Queue<int>(locks);

            Stack<int> bulletsCollection = new Stack<int>(bullets);

            int numberOfShootedBullets = 0;

            while (bulletsCollection.Count > 0 && locksCollection.Count > 0)
            {
                int bullet = bulletsCollection.Pop();

                if (bullet <= locksCollection.Peek())
                {
                    Console.WriteLine("Bang!");
                    locksCollection.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                numberOfShootedBullets++;
                if (numberOfShootedBullets % sizeOfGunBarrel == 0 && bulletsCollection.Count>0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (locksCollection.Count==0)
            {
                Console.WriteLine($"{bulletsCollection.Count} bullets left. Earned ${intelligence-numberOfShootedBullets*bulletPrice}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksCollection.Count}");
            }
        }
    }
}
