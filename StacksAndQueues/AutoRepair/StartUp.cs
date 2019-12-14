using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepair
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string[] cars = Console.ReadLine()
               .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            Stack<string> servedVehicles = new Stack<string>();

            Queue<string> notServerdVehicles = new Queue<string>(cars);

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commandArgs[0])
                {
                    case "History":
                        Console.WriteLine(string.Join(", ", servedVehicles));
                        break;

                    case "Service":
                        string carToBeServed = notServerdVehicles.Dequeue();
                        Console.WriteLine($"Vehicle {carToBeServed} got served.");
                        servedVehicles.Push(carToBeServed);
                        break;
                    case "CarInfo":
                        if (!notServerdVehicles.Contains(commandArgs[1]))
                        {
                            Console.WriteLine("Served.");
                        }
                        else
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        break;
                }
            }

            if (notServerdVehicles.Count > 0)
            {
                Console.WriteLine("Vehicles for service: " + string.Join(", ", notServerdVehicles));

            }

            Console.WriteLine("Served vehicles: " + string.Join(", ", servedVehicles));
        }
    }
}
