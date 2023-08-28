// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void TableSquare(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.WriteLine($"{count, 3} -> {Math.Pow(count, 2), 5}");
        count++;
    }
}

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);
