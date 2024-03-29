﻿// Напишите программу, которая принимает на вход
// Трехзначное число и на выходе показывает последнюю цифру
// этого числа
//456 -> 6
//782 -> 2
//918 -> 8

//ввод
Console.WriteLine("Введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;

if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10; //деление без остатка на 10 - выводится последняя цифра любого числа
    //вывод
    Console.WriteLine($"Последняя цифра {lastDigit}");
}
else Console.WriteLine("Введено некорректное число");