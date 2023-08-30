using System;
// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int Quantity(int num)
{
    if (num == 0) return 1;
    //if (num < 0) num *= -1; // проверка если отрицательное число
    int count = 0;
    while (num != 0) // та же проверка
    {
        num /= 10;
        count++;
    } 
    return count;
}
int quantity = Quantity(number);
Console.WriteLine($"В числе {number} -> {quantity} знаков");