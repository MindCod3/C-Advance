using System;
using System.Linq;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                int[] row = Console.ReadLine().Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                matrix[i] = row;
            }

            string command = "";

            while ((command=Console.ReadLine())!="END")
            {
                string[] commandArgs = command.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);

                if (row < 0 || row >= size || col < 0 || col >= size)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (commandArgs[0]=="Add")
                {
                    matrix[row][col] += int.Parse(commandArgs[3]);
                }
                else if (commandArgs[0] == "Subtract")
                {
                    matrix[row][col] -= int.Parse(commandArgs[3]);
                }
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[i]));
            }
        }
    }
}
