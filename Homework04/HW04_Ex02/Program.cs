// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int SumDigit(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int num = InputNum("Введите число: ");
Console.WriteLine($"Сумма всех цифр в числе {num} равна {SumDigit(num)}");
