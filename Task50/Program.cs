// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
        Console.WriteLine("  |");

    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();
Console.Write("Введите номер строки -> ");
int rowsNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца -> ");
int columnsNum = Convert.ToInt32(Console.ReadLine());

if (rowsNum <= 0 || columnsNum <= 0) Console.WriteLine("Введены неправильные значения.");
Console.WriteLine();
if ((rowsNum -= 1) < array2d.GetLength(0) && (columnsNum -= 1) < array2d.GetLength(1)) Console.WriteLine($"Значение элемента равно -> {array2d[rowsNum, columnsNum]}");
else Console.WriteLine($"Такой позиции в массиве нет.");
Console.WriteLine();