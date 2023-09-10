// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
/*
void FindNum(int[] fNum, int num)                                                                                                    // Определить метод с именем «FindNum», который принимает в качестве параметров целочисленный массив «fNum» и целое число «num».
{
    int count = 0;                                                                                                                   // Инициализируем счетчик count равным 0.
    for (int i = 0; i < fNum.Length; i++)                                                                                            // Запускаем цикл, который проходит по каждому элементу массива 'fNum'.
    {
        if (fNum[i] == num)                                                                                                          // Проверяем, равен ли текущий элемент «fNum» «num».
            count++;                                                                                                                 // Если равно, увеличиваем переменную count.
    }
    if (count==0)                                                                                                                    // Проверяем значение count, чтобы определить, найдено ли в массиве число.
    {
        System.Console.WriteLine("нет");                                                                                             // Если число не найден, выводим "нет" (no).
    }
    else
    {
        System.Console.WriteLine("да");                                                                                              // Если число найден, выводим «да» (да).
    }
}
    
void PrintArr(int[] array)                                                                                                           // Определить метод с именем PrintArr, который принимает в качестве параметра целочисленный массив array.
{
    for (int i = 0; i < array.Length; i++)                                                                                           // Запускаем цикл, который проходит по каждому элементу массива.
    {

        Console.Write(array[i]);                                                                                                     // Печатаем текущий элемент массива.
        if (i < array.Length - 1) Console.Write(", ");                                                                               // Если текущий элемент не является последним элементом в «массиве», выведите запятую и пробел.

    }
    Console.WriteLine();                                                                                                             // Печатаем новую строку, чтобы перейти к следующей строке после печати всех элементов.
}
int[] oneArray = {-6, 10, -17, 28, 8, 0, 7 };                                                                                        // Объявляем целочисленный массив oneArray с начальными значениями.
PrintArr(oneArray);                                                                                                                  // Вызов метода PrintArr для печати исходного содержимого oneArray.
FindNum(oneArray, 3233);                                                                                                             // Вызовите метод FindNum, чтобы проверить, существует ли «9» в «oneArray», и выведите «да» или «нет».

*/

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
Console.Write($"{arr[i]} ");
Console.WriteLine();
}

string FindNum(int[] ints, int searching)
{
for (int i = 0; i < ints.Length; i++)
if(ints[i] == searching)
return "да";
return "нет";
}

int[] smth = {1, 2, 3 ,4 ,5};
PrintArray(smth);
Console.WriteLine(FindNum(smth, 6));
