//Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("введите 1e число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 2e число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

bool res = MuliplicytyTwoNumbers(numb1, numb2);
Console.WriteLine(res ? "ДА" : "НЕТ");

bool MuliplicytyTwoNumbers(int num1, int num2)
{
    return num1 / num2 == num2 || num2 / num1 == num1;
}