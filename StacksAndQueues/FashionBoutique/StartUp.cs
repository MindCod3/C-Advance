using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int[] clothes = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> box = new Stack<int>(clothes);

            int currentRackCapacity = 0;
            int numberOfUsedRacks = 1;

            while (box.Count>0)
            {
                int currentClothe = box.Pop();

                if (currentClothe+currentRackCapacity<=rackCapacity)
                {
                    currentRackCapacity += currentClothe;
                }
                else
                {
                    numberOfUsedRacks++;
                    currentRackCapacity = currentClothe;
                }
            }

            Console.WriteLine(numberOfUsedRacks);
        }
    }
}
