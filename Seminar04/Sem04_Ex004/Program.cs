// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int EnterNum(string phrase)
{
Console.WriteLine(phrase);
return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(2);
}
}

void PrintArray (int[] array)
{
foreach (int value in array)
{
Console.Write(value + " ");
}
}
void Dell(int a)
{
a/=2;
}
int size = EnterNum("Enter number for array, please");
int[] arr = new int[size];

FillArray(arr);
PrintArray(arr);
Dell(size);

System.Console.WriteLine();
//Console.WriteLine(b);
Console.WriteLine(size);