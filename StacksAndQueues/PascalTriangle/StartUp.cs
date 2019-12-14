using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] matrix = new long[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new long[i+1];

                for (int j = 0; j < i+1; j++)
                {
                    if (j == 0 || j ==i)
                    {
                        matrix[i][j] = 1;
                    }
                    else
                    {
                        matrix[i][j] = matrix[i - 1][j - 1] + matrix[i - 1][j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[i]));
            }
        }
    }
}
