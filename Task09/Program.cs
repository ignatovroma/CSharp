//Напишите программу, которая 
//1.выводит случайное число из отрезка [10,99] и 
//2.показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 --> {number}");

//int firstDigit = number / 10;
//int secondDigit = number % 10;

//if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
//else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");

//или через тернарный оператор
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");

//Реализация через методы

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    //if (firstDigit > secondDigit) return firstDigit;
    //return secondDigit;

    //int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    //return result;
    
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

