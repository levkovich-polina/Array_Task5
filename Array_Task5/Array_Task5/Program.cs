using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrix1 = new int[10, 10];
            int[,] matrix2 = new int[10, 10];
            int[,] matrix3 = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix1[i, j] = random.Next(1, 10);
                    matrix2[i, j] = random.Next(1, 10);
                }
            }

            Console.WriteLine("1 матрица:");
            PrintArray(matrix1);
            Console.WriteLine("2 матрица:");
            PrintArray(matrix2);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < 10; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    matrix3[i, j] = sum;
                }
            }
            Console.WriteLine("Результат умножения матриц:");
            PrintArray(matrix3);
            Console.ReadLine();
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }

                Console.WriteLine();
            }

        }
    }
}
