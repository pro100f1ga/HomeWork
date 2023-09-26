// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int EnterNumber(string phrase)
{
    Console.Write(phrase);
    return int.Parse(Console.ReadLine()!);
}

int ReturnSumNumberHimDigits(int number)
{

    if (number == 0) return 0;

    return ReturnSumNumberHimDigits(number / 10) + number % 10;

}

int numb = EnterNumber("Введите число: ");
int sum = ReturnSumNumberHimDigits(numb);
Console.WriteLine("Сумма знаков в числе: " + sum);