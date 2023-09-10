// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int EnterNum(string phrase)
{

Console.Write(phrase);
return int.Parse(Console.ReadLine()!);
}

int number = EnterNum("Введите число: ");

string Transformation(int number)
{
string result = "";
while (number != 0)
{
int temp = number % 2;
result = $"{temp}" + result;
number /= 2;
}

return result;
}

Console.WriteLine(Transformation(number));