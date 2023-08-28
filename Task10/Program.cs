// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру 
// этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Promt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Promt("Введите трёхзначное число: ");
if (number < 100 || number > 1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число, повоторите ввод");
    return;
}
Console.WriteLine($"Введенное число `{number}`");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра `{secondRank}`");

/*int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Не правильное количество, попробуйте ввести заново! ");
}
else
{
    Console.WriteLine(InCenter(number));
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{

    int result = ((a / 10) % 10);
    return result;
}
*/