// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateArr(int first, int second)
{
    int[,] array = new int[first, second];
    return array;
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < arr.GetLength(1) - j - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = CreateArr(rows, columns);

int minValue = InputNum("Введите минимальное значение: ");
int maxValue = InputNum("Введите максимальное значение: ");
FillArray(myArray, minValue, maxValue);

Console.WriteLine("Исходный массив:");
PrintArray(myArray);

SortArray(myArray);

Console.WriteLine("Массив после сортировки строк по убыванию:");
PrintArray(myArray);