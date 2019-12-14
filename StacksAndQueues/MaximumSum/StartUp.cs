using System;
using System.Linq;

namespace SumMatrixElements
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
                int[] row = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[i] = row;
            }

            int sumFinal = 0;
            int rowMax = 0;
            int colMax = 0;

            for (int i = 0; i < matrixSize[0] - 1; i++)
            {
                for (int j = 0; j < matrixSize[1] - 1; j++)
                {
                    int sum = matrix[i][j] + matrix[i][j + 1] + matrix[i + 1][j] + matrix[i + 1][j + 1];

                    if (sum > sumFinal)
                    {
                        sumFinal = sum;
                        rowMax = i;
                        colMax = j;
                    }
                }
            }

            Console.WriteLine($"{matrix[rowMax][colMax]} {matrix[rowMax][colMax + 1]}");
            Console.WriteLine($"{matrix[rowMax + 1][colMax]} {matrix[rowMax + 1][colMax + 1]}");
            Console.WriteLine(sumFinal);

        }
    }
}
