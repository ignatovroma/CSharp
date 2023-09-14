// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Promt(string message)
{
    Console.Clear();
    Console.Write(message); //вывести сообщение
    var value = Console.ReadLine(); //считывает с консоли строку
    int result = Convert.ToInt32(value); //преобразует строку в целое число
    Console.Clear();
    return result;
}

int m = Promt("Введите 1ое положительное число: ");
int n = Promt("Введите 2ое положительное число: ");


int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int result = AckermannFunction(m, n);
Console.WriteLine();
Console.WriteLine($"    A({m}, {n}) = {result}");
Console.WriteLine();
Console.ReadKey();