// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int InputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
return new int[rows, columns];
}

void Fill2DArray(int[,] ints, int minValue, int maxValue)
{
Random rnd = new Random();
for (int i = 0; i < ints.GetLength(0); i++)
for (int j = 0; j < ints.GetLength(1); j++)
ints[i, j] = rnd.Next(minValue, maxValue + 1); // Next(2, 5) -> [2, 5)
}

void ConvertArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i += 2)
{
for (int j = 0; j < array.GetLength(1); j += 2)
{
array[i,j] *= array[i,j];
}
}
}

void Print2DArray(int[,] ints)
{
for (int i = 0; i < ints.GetLength(0); i++)
{
for (int j = 0; j < ints.GetLength(1); j++)
Console.Write($"{ints[i, j]}\t");
Console.WriteLine();
}
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int min = InputNum("Введите минимальное значение диапазона: ");
int max = InputNum("Введите максимальное значение диапазона: ");

int[,] anyArray = Create2DArray(rows, cols);
Fill2DArray(anyArray, min, max);
Print2DArray(anyArray);
Console.WriteLine();
ConvertArray(anyArray);
Print2DArray(anyArray);