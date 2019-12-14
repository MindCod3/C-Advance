using System;
using System.Linq;
namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];

            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();
                matrix[i] = row.ToCharArray();
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                if (matrix[i].Any(x=>x==symbol))
                {
                    Console.WriteLine($"({i}, {string.Join("",matrix[i]).IndexOf(symbol)})");
                    return;
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
