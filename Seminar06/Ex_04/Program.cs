// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int EnterNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

void Fibo(int num)
{
int prevNum = 1;
int prevPrevNum = 0;
if (num == 1)
Console.WriteLine($"При {num} последовательность равна 0");
else
{
Console.Write($"{prevPrevNum} {prevNum}");
for(int i = 3; i <= num; i++)
{
int nextFibo = prevNum + prevPrevNum;
Console.Write($" {nextFibo}" );
prevPrevNum = prevNum;
prevNum = nextFibo;
}
}
}

int num = EnterNum("Введите число: ");
Fibo(num);