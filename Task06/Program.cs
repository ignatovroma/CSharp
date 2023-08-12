//Напишите программу, которая на вход 
//принимает число и выдаёт, 
//является ли число чётным 
//(делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int number = num % 2;
if (number == 0)
{
    Console.WriteLine("Число " + num + " четное");
}
else
{
    Console.WriteLine("Число " + num + " нечетное");
}