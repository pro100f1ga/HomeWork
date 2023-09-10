// Задайте массив заполненный случайными проявлениями трехзначными числами. Напишите программу, которая определяет количество чётных чисел в массиве.
// Например: [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (IsEven(array[i]))
        {
            Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine();
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsEven(array[i]))
        {
            count++;
        }
    }
    return count;
}

bool IsEven(int number)
{
    return number % 2 == 0;
}

int arraySize = 10;
int[] randomNumbers = new int[arraySize];

FillArray(randomNumbers);
PrintArray(randomNumbers);

int evenCount = CountEvenNumbers(randomNumbers);
Console.WriteLine($"{evenCount}");

