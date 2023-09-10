// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int InputInteger(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

double[] CreateDoubleArr(int size)
{
return new double[size];
}

void FillDoubleArr(double[] arr, int minValue, int maxValue)
{
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
arr[i] = Math.Round(rnd.NextDouble()+ rnd.Next(minValue, maxValue), 2);
}

void ReverseArray(double[] arr)
{
for(int i = 0; i < arr.Length / 2; i++)
{
// 1 2 3 4 5 i = 0 k = arr.Length - 1 - i k = 4
// temp = 5 arr[k] = 1 arr[i] = 5 -> 52341
// i = 1 k = 3 arr[1] = 2 arr[3] = 4
// temp = 4 arr[k] = 2 arr[i] = 4 -> 54321
double temp = arr[arr.Length - 1 - i];
arr[arr.Length - 1 - i] = arr[i];
arr[i] = temp;
// (arr[arr.Length - 1 - i], arr[i]) = (arr[i], arr[arr.Length - 1 - i]);
// 5 и 2 -> 5 + 2 = 7 7 - 2 = 5 7 -5 =2
// arr[arr.Length - 1 - i] = arr[arr.Length - 1 - i] + arr[i];
// arr[i] = arr[arr.Length - 1 - i] - arr[i];
// arr[arr.Length - 1 - i] = arr[arr.Length - 1 - i] - arr[i];
}
}

void PrintArr(double[] arr)
{
for (int i = 0; i < arr.Length; i++)
Console.Write($"{arr[i]} ");
Console.WriteLine();
}

int size = InputInteger("Введите размер массива: ");
int min = InputInteger("Введите минимальное значение элемента: ");
int max = InputInteger("Введите максимальное значение элемента: ");

double[] array = CreateDoubleArr(size);
FillDoubleArr(array, min, max);
PrintArr(array);
ReverseArray(array);
PrintArr(array);