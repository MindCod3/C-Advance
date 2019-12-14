using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> mapOfPumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] pumpOilDistance = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray();

                mapOfPumps.Enqueue(pumpOilDistance);
            }

            int indexPosition = 0;

            while (true)
            {
                int amountPetrol = 0;
                bool passAllStation = true;

                for (int i = 0; i < n; i++)
                {
                    int[] pumpStation = mapOfPumps.Dequeue();
                    mapOfPumps.Enqueue(pumpStation);
                    if (pumpStation[0] + amountPetrol >= pumpStation[1])
                    {
                        amountPetrol = amountPetrol + pumpStation[0] - pumpStation[1];
                    }
                    else
                    {
                        passAllStation = false;
                        indexPosition = indexPosition + i + 1;
                        break;
                    }
                }

                if (passAllStation)
                {
                    break;
                }

            }

            Console.WriteLine(indexPosition);
        }
    }
}
