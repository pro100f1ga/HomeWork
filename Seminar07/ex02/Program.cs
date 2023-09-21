// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m + n.Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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

void FillArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = i + j;
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
}
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = CreateArr(rows, columns);
FillArray(myArray);
PrintArray(myArray);