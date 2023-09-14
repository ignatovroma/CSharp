// Задача 61: Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        int N = 5; // Замените на нужное число строк треугольника

        int[][] triangle = new int[N][];

        for (int i = 0; i < N; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;
            triangle[i][i] = 1;

            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }

        // Вывод равнобедренного треугольника
        for (int i = 0; i < N; i++)
        {
            Console.Write(new string(' ', (N - i - 1) * 2));

            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{triangle[i][j]:D2}  ");
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}