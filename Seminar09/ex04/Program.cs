// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double Powered(int num, int degree)
{
    //double degreeDouble= Convert.ToDouble(degree);
    if (degree == 0)
        return 1;
    else if (degree > 0)
    {
        return num * Powered(num, --degree);
    }
    else
    {
        return 1.0 / num * Powered(num, ++degree);
    }
}

int num = InputNum("Input number please: ");
int degree = InputNum("Input degree please: ");
Console.WriteLine(Powered(num, degree));