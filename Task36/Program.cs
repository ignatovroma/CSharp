// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumOddIndex(int[] arr)
{
    int num = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        num += arr[i];
    }
    return num;
}

int[] array = CreateArrayRndInt(4, -10, 10);
int sumOddIndex = SumOddIndex(array);

PrintArray(array);
Console.Write($"Сумма чисел с нечетными индексами в массиве равна {sumOddIndex}");