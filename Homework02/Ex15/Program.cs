//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool IsWeekend(int day)
{
    return day == 6 || day == 7;
}

int ValidateDayWeekday()
{
    int day;
    do
    {
        Console.Write("Введите день недели (1 для Понедельника, 2 для Вторника , ..., 7 для Воскресенья): ");
    } while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7);
    return day;
}

int dayOfWeek = ValidateDayWeekday();

if (IsWeekend(dayOfWeek))
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это не выходной день");
}
