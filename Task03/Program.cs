﻿// Напишите программу, которая будет выдвать
// Дни недели по заданному номеру

// 3-> Среда
// 5-> Пятница


Console.WriteLine("Введите номер от 01 до 07 номер недели");
string? num = Console.ReadLine();

    if (num == "1")
    {
        Console.WriteLine("Понедельник");
    }
    else if (num == "2") 
    {
        Console.WriteLine("Вторник");
    }
    else if (num == "3") 
    {
        Console.WriteLine("Среда");
    }
    else if (num == "4") 
    {
        Console.WriteLine("Четверг");
    }
    else if (num == "5") 
    {
        Console.WriteLine("Пятница");
    }
    else if (num == "6") 
    {
        Console.WriteLine("Суббота");
    }
    else if (num == "7") 
    {
        Console.WriteLine("Воскресенье");
    }
    else
    {
        Console.WriteLine("Некорректное ввод");
    }