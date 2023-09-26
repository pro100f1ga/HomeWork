// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
int InputNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
// void PrintNumbers(int n)
// {
// if (n > 0)
// {
// PrintNumbers(n-1);
// Console.Write(n + " ");
// }
// }
string PrintNumbers(int n, int start)
{
    if (start == n)
        return n.ToString();
    return start + " " + PrintNumbers(n, start + 1);
}
int number = InputNum("Введите число: ");
Console.WriteLine(PrintNumbers(number, 1));