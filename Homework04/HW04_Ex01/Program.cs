// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int Exponent(int number, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= number;
    }
    return result;
}
bool ValidateExponent(int power)
{
    if (power < 0)
    {
        System.Console.WriteLine("Степень не должна быть равна 0");
        return false;
    }
    return true;

}

int Number = InputNum("Введите число: ");
int power = InputNum("Введите степень: ");
int result = Exponent(Number, power);
if (ValidateExponent(power))
{
    Console.WriteLine($"{Number}^{power} = {result}");
}

