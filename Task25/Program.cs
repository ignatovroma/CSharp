// Напишите программу, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadDigit(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int firstDigit = ReadDigit("Введите число: ");
int secondDigit = ReadDigit("Введите степень числа: ");

int NumberPow(int number)
{
    int num = 1;
    for (int i = 0; i < secondDigit; i++)
    {
        checked
        {
            num *= firstDigit;
        }
    }
    return num;
}

int result = NumberPow(secondDigit);
Console.WriteLine($"Натуральная {secondDigit} степень числа {firstDigit} равна -> {result}");