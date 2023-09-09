// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// 1ый способ

// Console.WriteLine("Введите число более одного");
// int number = int.Parse(Console.ReadLine()!);
// int count = 0;
// while (number !=0)
// {
// number  /=10;
// count++;
// }
// System.Console.WriteLine(count);

// 2ой способ

/* НИРАБОТАЕТ =/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum("Введите число: ");
int i;
for (int i = 0; i < length; i++);
    num /= 10;
System.Console.WriteLine(i);
*/