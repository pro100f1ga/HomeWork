// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool SwapNum(int num1, int num2)
{
    return num2 > num1;
}

void PrintNumbers(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.Write(num1);
        return;
    }
    if (SwapNum(num1, num2))
    {

        Console.Write(num1 + " ");
        PrintNumbers(++num1, num2);
    }
    else
    {
        Console.Write(num1 + " ");
        PrintNumbers(--num1, num2);
    }
}

int firstNum = InputNum("Input first num: ");
int secondNum = InputNum("Input second num: ");
PrintNumbers(firstNum, secondNum);