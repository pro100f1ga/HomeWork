// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double FindDifference(double[] array)
{

    if (array.Length == 0)
    {
        return -1;
    }
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }

    double difference = max - min;
    return difference;
}

double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };
double difference = FindDifference(numbers);
Console.WriteLine($"{difference}");


