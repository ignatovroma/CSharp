//Напишите программу, которая будет
//1.принимать на вход числа
// и
//2.выводить, является ли первое число кратным второму.
//3.Если первое число не кратно второму,
//то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("введите число первое");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число второе");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = Result(num1, num2);
if (result == 0) Console.WriteLine("КРАТНО");
else Console.WriteLine($"НЕ КРАТНО, ОСТАТОК {result}");

int Result(int numb1, int numb2)
{
    return numb1 % numb2;
}
