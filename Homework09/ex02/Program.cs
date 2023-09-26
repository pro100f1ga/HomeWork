// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumNaturalNumbers(int m, int n)
{
    if (n < m)
        return 0;
    return n + SumNaturalNumbers(m, n - 1);
}

int M = InputNum("Введите значение M: ");
int N = InputNum("Введите значение N: ");
int sum = SumNaturalNumbers(M, N);
Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N}: {sum}");
