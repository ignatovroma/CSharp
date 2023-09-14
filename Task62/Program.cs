// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

//     -0- -1- -2- -3-
// -0-  01  02  03  04
// -1-  12  13  14  05
// -2-  11  16  15  06
// -3-  10  09  08  07

int Promt(string message)
{
    Console.Clear();
    Console.Write(message); //вывести сообщение
    var value = Console.ReadLine(); //считывает с консоли строку
    int result = Convert.ToInt32(value); //преобразует строку в целое число
    Console.Clear();
    return result;
}

int[,] CreateSpiralMatrix(int sizeSideMatrix)
{
    int[,] matrix = new int[sizeSideMatrix, sizeSideMatrix];

    int firstRow = 0,
        lastRow = sizeSideMatrix - 1,
        firstColumn = 0,
        lastColumn = sizeSideMatrix - 1;

    int value = 1;

    while (value <= sizeSideMatrix * sizeSideMatrix)
    {
        for (int i = firstColumn; i <= lastColumn; i++)
            matrix[firstRow, i] = value++;
        firstRow++;

        for (int i = firstRow; i <= lastRow; i++)
            matrix[i, lastColumn] = value++;
        lastColumn--;

        for (int i = lastColumn; i >= firstColumn; i--)
            matrix[lastRow, i] = value++;
        lastRow--;

        for (int i = lastRow; i >= firstRow; i--)
            matrix[i, firstColumn] = value++;
        firstColumn++;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]:D2} ");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine();
    Console.ReadLine();
}

int number = Promt("Введите длину стороны матрицы -> ");
var result = CreateSpiralMatrix(number);
PrintMatrix(result);