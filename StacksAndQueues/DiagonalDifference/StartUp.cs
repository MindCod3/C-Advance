using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                int[] row = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                matrix[i] = row;
            }

            int primaryDiagonal = 0;

            for (int i = 0; i < size; i++)
            {
                primaryDiagonal += matrix[i][i];
            }

            int secondaryDiagonal = 0;

            for (int i = size-1; i>=0; i--)
            {
                secondaryDiagonal += matrix[i][size - i - 1];
            }

            int diff = Math.Abs(primaryDiagonal - secondaryDiagonal);

            Console.WriteLine(diff);
        }
    }
}
