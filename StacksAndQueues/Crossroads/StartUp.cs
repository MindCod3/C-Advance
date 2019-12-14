using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine());

            int window = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string input;

            int passedCarCount = 0;

            while ((input = Console.ReadLine()) != "END")
            {

                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int greenLightCurrent = seconds;

                    while (cars.Count > 0 && greenLightCurrent > 0)
                    {
                        string car = cars.Dequeue();

                        if (greenLightCurrent - car.Length >= 0)
                        {
                            passedCarCount++;
                            greenLightCurrent -= car.Length;
                        }
                        else
                        {
                            if (greenLightCurrent + window - car.Length >= 0)
                            {
                                passedCarCount++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {car[greenLightCurrent + window]}.");
                                return;
                            }
                        }

                    }
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCarCount} total cars passed the crossroads.");
        }
    }
}
