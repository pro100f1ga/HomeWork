// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int EnterNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

bool IsTriangle(int a, int b, int c)
{
return (a + b > c && a + c > b && b + c > a);
}

int firstSide = EnterNum("Введите длину первой стороны: ");
int secondSide = EnterNum("Введите длину второй стороны: ");
int thirdSide = EnterNum("Введите длину третьей стороны: ");

Console.WriteLine($"При заданных длинах сторон возможность существования треугольника: {IsTriangle(firstSide, secondSide, thirdSide)}");