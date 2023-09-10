// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int InputNum(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
return new int[size];
}

void FillArray(int[] array, int minValue, int maxValue)
{
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = rnd.Next(minValue, maxValue + 1);
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
Console.Write($"{array[i]} ");
Console.WriteLine();
}

int[] MultPairs(int[] array)
{
int size = array.Length / 2 + array.Length % 2;
// int size = array.Length / 2;
// if (array.Length % 2 == 1) size++;
int[] newArr = new int[size];

for (int i = 0; i < array.Length / 2; i++)
newArr[i] = array[i] * array[array.Length - 1 - i];

if (array.Length % 2 == 1)
newArr[size - 1] = array[array.Length / 2];
return newArr;
}

int size = InputNum("Введите размер массива: ");
int[] ints = CreateArray(size);

int min = InputNum("Введите минимальное значение элемента массива: ");
int max = InputNum("Введите максимальное значение элемента массива: ");

FillArray(ints, min, max);
PrintArray(ints);

int[] result = MultPairs(ints);
PrintArray(result);