// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

void Print2DArray(int[,] ints)
{
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
            Console.Write($"{ints[i, j]}\t");
        Console.WriteLine();
    }
}

int[] GetIndex(int[,] array)
{
    int min = array[0, 0];
    int[] indexes = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }

        }
    }
    return indexes;
}

int[,] CutArray(int[,] array, int[] indexes)
{
    int[,] arr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == indexes[0])
            continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == indexes[1])
                continue;
            arr[row, column] = array[i, j];
            column++;
        }
        row++;
        column = 0;
    }
    return arr;
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int min = InputNum("Введите минимальное значение диапазона: ");
int max = InputNum("Введите максимальное значение диапазона: ");

int[,] originalArray = Create2DArray(rows, cols);
Fill2DArray(originalArray, min, max);
Print2DArray(originalArray);
Console.WriteLine();

int[] coord = GetIndex(originalArray);
int[,] cut2d = CutArray(originalArray, coord);
Print2DArray(cut2d);
