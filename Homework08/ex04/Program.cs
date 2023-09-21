// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GenerateUniqueTwoDigitArray(int xSize, int ySize, int zSize)
{
    int[,,] array = new int[xSize, ySize, zSize];
    int minValue = 10; 
    int maxValue = 99; 
    Random random = new Random();


    bool[] usedNumbers = new bool[maxValue - minValue + 1];

    for (int x = 0; x < xSize; x++)
    {
        for (int y = 0; y < ySize; y++)
        {
            for (int z = 0; z < zSize; z++)
            {
                int randomNumber;
                do
                {
                    randomNumber = random.Next(minValue, maxValue + 1);
                } while (usedNumbers[randomNumber - minValue]);

                array[x, y, z] = randomNumber;
                usedNumbers[randomNumber - minValue] = true;
            }
        }
    }

    return array;
}

void Print3DArray(int[,,] array)
{
    int xSize = array.GetLength(0);
    int ySize = array.GetLength(1);
    int zSize = array.GetLength(2);

    for (int x = 0; x < xSize; x++)
    {
        for (int y = 0; y < ySize; y++)
        {
            for (int z = 0; z < zSize; z++)
            {
                Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] threeDArray = GenerateUniqueTwoDigitArray(2, 2, 2);
Print3DArray(threeDArray);