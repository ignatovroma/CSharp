// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadDigit(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// int Promt(string message)
// {
//     Console.WriteLine(message);
//     string readInput = Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }

int SumDigit(int num)
{
    int sum = 0;
    while(num >0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

int number = ReadDigit("Введите число: ");
Console.WriteLine($"Сумма всех чисел в цифре {number} равна {SumDigit(number)}");