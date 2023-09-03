// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
double[] arr = new double[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.NextDouble() * (max - min) + min;
}
return arr;
}

void PrintArrayDouble(double[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
else Console.Write($"{arr[i]:F1}");
}
Console.WriteLine("]");
}

double MinDoubleNumber(double[] arr)
{
    double minnum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(minnum > arr[i]) minnum = arr[i];
    }
    return minnum;
}

double MaxDoubleNumber(double[] arr)
{
    double maxnum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(maxnum < arr[i]) maxnum = arr[i];
    }
    return maxnum;
}

double DiffMinMax(double minnumber, double maxnumber)
{
    double diffMinMax = maxnumber - minnumber;
    return diffMinMax;
}

double[] array = CreateArrayRndDouble(5, 1, 20);
double min = MinDoubleNumber(array);
double max = MaxDoubleNumber(array);
double diff = DiffMinMax(min, max);

System.Console.WriteLine();
PrintArrayDouble(array);
System.Console.WriteLine();
Console.WriteLine($"Минимум равен -> {min:F1}");
System.Console.WriteLine();
Console.WriteLine($"Максимум равен -> {max:F1}");
System.Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна -> {diff:F1}");
System.Console.WriteLine();