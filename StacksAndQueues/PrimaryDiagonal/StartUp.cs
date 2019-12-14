using System;
using System.Linq;

namespace PrimaryDiagonal
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

            int DiagonalBottonToUpper = 0;

            for (int i = 0; i < size; i++)
            {
                DiagonalBottonToUpper += matrix[i][i];
            }

            int DiagonalTopToBotton = 0;

            for (int i = size-1; i >=0; i--)
            {
                DiagonalTopToBotton += matrix[i][size - 1 - i];
            }

            Console.WriteLine(DiagonalBottonToUpper);
            //Console.WriteLine(DiagonalTopToBotton);
        }
    }
}
