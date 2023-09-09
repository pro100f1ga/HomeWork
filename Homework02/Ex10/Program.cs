// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int ThreeDigit(string message)
{
    System.Console.Write(message); 
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = ThreeDigit("Введите трехзначное число > ");
if (number < 100 || number >= 1000)
{
    System.Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;
}
System.Console.WriteLine($"Введите трехзначное число {number}");
int secondRank = number / 10% 10;
System.Console.WriteLine($"Вторая цифра {secondRank}");
