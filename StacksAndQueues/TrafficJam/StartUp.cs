using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string input;

            int  passedCars = 0;

            while ((input=Console.ReadLine())!="end")
            {
                if (input=="green")
                {
                    if (greenLight>cars.Count)
                    {
                        greenLight = cars.Count;
                    }

                    for (int i = 0; i < greenLight; i++)
                    {
                        Console.WriteLine(cars.Dequeue()+" passed!");
                        passedCars++;
                    }
                    continue;
                }
                else
                {
                    cars.Enqueue(input);
                }
            }

            Console.WriteLine("{0} cars passed the crossroads.",passedCars);
        }
    }
}
