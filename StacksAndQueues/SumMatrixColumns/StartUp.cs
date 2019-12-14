using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int[][] matrix = new int[matrixSize[0]][];

            for (int i = 0; i < matrixSize[0]; i++)
            {
                int[] row = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                matrix[i] = row;
            }

            for (int i = 0; i < matrixSize[1]; i++)
            {
                int sum = 0;
                for (int j = 0; j < matrixSize[0]; j++)
                {
                    sum += matrix[j][i];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
