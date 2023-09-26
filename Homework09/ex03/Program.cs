// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

int Akkerman(int m, int n)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Значения m и n должны быть неотрицательными.");
        return -1; // Возвращаем -1 в случае ошибки
    }

    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    else
        return -1; // Возвращаем -1 в случае ошибки
}

int m = InputNum("Введите значение m: ");
int n = InputNum("Введите значение n: ");
int result = Akkerman(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}