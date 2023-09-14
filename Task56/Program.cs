// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArrayRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

int[] SumsNumsRows(int[,] matrix)
{
    int[] arrSumsRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRows = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRows += matrix[i, j];
        }
        arrSumsRows[i] = sumRows;
        Console.Write($" {sumRows:D2}"+"; ");
        Console.WriteLine();
    }
    return arrSumsRows; 
}

int MinSumNumRow(int[] arr)
{
    int minsum = arr[0];
    int minsumindex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (minsum > arr[i]) 
        {
            minsum = arr[i]; 
            minsumindex = i;
        }    
    }
    return minsumindex + 1;
}

int[,] array = CreateArrayRndInt(4, 4, -9, 9);
PrintMatrix(array);
int[] sumsNumsRows = SumsNumsRows(array);
int res = MinSumNumRow(sumsNumsRows);
Console.WriteLine($"Строка с наименьшей суммой элементов -> {res} строка");