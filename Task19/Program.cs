using System;
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadDigit(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool PalinDrome(int a)
{
    int firstDigit = a / 10000;
    int secondDigit = ((a / 1000) % 10);
    int fourthDigit = ((a / 10) % 10);
    int fifthDigit = a % 10;

    bool result = (firstDigit == fifthDigit && secondDigit == fourthDigit);
    return result;
}        

int number = ReadDigit("Введите пятизначное число: ");

int amount = (int)Math.Log10(Math.Abs(number)) + 1;
if (amount < 5 || amount > 5)
{
    Console.WriteLine("Вы ввели не пятизначное число, повоторите ввод.");
}
else
{
    if (PalinDrome(number) == true)
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом.");
    }
}  
