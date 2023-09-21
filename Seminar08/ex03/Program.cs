// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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
int[] TransferValues(int[,] array)
{
    int[] values = new int[array.Length];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            values[index] = array[i, j];
            index++;
        }
    }
    return values;
}
void SortArray(int[] ints)
{
    int max = ints[0];
    for (int i = 0; i < ints.Length; i++)
    {
        for (int j = 0; j < ints.Length - 1; j++)
        {
            if (ints[j] > ints[j + 1])
            {
                max = ints[j];
                ints[j] = ints[j + 1];
                ints[j + 1] = max;
            }
        }
    }
}
void Frequecy(int[] array)
{
    int count = 1;
    int element = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == element)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{element} встречается {count} раз");
            count = 1;
            element = array[i];
        }
    }
    Console.WriteLine($"{element} встречается {count} раз");
}
int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int min = InputNum("Введите минимальное значение диапазона: ");
int max = InputNum("Введите максимальное значение диапазона: ");

int[,] originalArray = Create2DArray(rows, cols);
Fill2DArray(originalArray, min, max);
Print2DArray(originalArray);
Console.WriteLine();

int[] array = TransferValues(originalArray);
SortArray(array);
Console.WriteLine(string.Join(" ", array));
Frequecy(array);