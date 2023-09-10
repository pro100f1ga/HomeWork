
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputArray(int count)
{
    int[] numbers = new int[count];

    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент ");
        numbers[i] = int.Parse(Console.ReadLine());
    }

    return numbers;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++; 
        }
    }
    return count;
}

Console.Write("Введите количество элементов:  ");
int M = int.Parse(Console.ReadLine());

int[] numbers = InputArray(M); 
int countPositive = CountPositiveNumbers(numbers); 

Console.WriteLine($"Количество чисел больше 0:  {countPositive}");