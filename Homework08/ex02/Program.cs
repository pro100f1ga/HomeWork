// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateArr(int rows, int columns)
{
    int[,] array = new int[rows, columns];
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

int FindRowWithMinSum(int[,] arr)
{
    int minSum = int.MaxValue;
    int rowIndex = -1;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            rowSum += arr[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            rowIndex = i;
        }
    }

    return rowIndex;
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = CreateArr(rows, columns);

int minValue = InputNum("Введите минимальное значение: ");
int maxValue = InputNum("Введите максимальное значение: ");
FillArray(myArray, minValue, maxValue);

Console.WriteLine("Исходный массив:");
PrintArray(myArray);

int rowWithMinSum = FindRowWithMinSum(myArray);
if (rowWithMinSum != -1)
{
    Console.WriteLine($"Строка с наименьшей суммой элементов: {rowWithMinSum + 1}");
}
else
{
    Console.WriteLine("Массив пустой.");
}
