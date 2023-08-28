// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("день " + a + " - (ДА) - Выходной день.");
        }
        else
        {
            Console.Write("день " + a + " - (НЕТ) - Рабочий день. ");
        }
    }
    else
    {
        Console.Write(" Вы не можете ввести число больше, так как в неделе - 7 дней");
    }
    return(" ( Если вам надо узнать день недели выходной он или нет, попробуйте ввести заново, перезапустив программу. )");
}
*/

int Promt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}

int weekDay = Promt("Введите день недели: ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Наконец-то выходной");
    }
    else
    {
        Console.WriteLine("Придётся работать");
    }
}