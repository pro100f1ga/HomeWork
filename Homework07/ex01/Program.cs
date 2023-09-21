// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размеренность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.

// m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;

public class Answer {
  // Создаем один экземпляр класса Random для генерации случайных чисел в коде.
  static Random random = new Random();

  // Метод CreateRandomMatrix принимает размеры m и n, а также границы случайных чисел minLimitRandom и maxLimitRandom.
  public static double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
    // Создаем двумерный массив с размерами m x n для хранения случайных чисел.
    double[,] matrix = new double[m, n];

    // Вложенными циклами заполняем каждый элемент массива случайным числом.
    for (int i = 0; i < m; i++) {
      for (int j = 0; j < n; j++) {
        // Генерируем случайное целое число в заданном диапазоне и добавляем случайное вещественное число от 0 до 1.
        matrix[i, j] = random.Next(minLimitRandom, maxLimitRandom + 1) + random.NextDouble();
      }
    }

    // Возвращаем созданный двумерный массив.
    return matrix;
  }

  // Метод PrintArray принимает двумерный массив и выводит его на консоль.
  public static void PrintArray(double[,] matrix) {
    // Используем два вложенных цикла для перебора всех элементов массива.
    for (int i = 0; i < matrix.GetLength(0); i++) {
      for (int j = 0; j < matrix.GetLength(1); j++) {
        // Выводим каждый элемент массива с форматированием, чтобы отображать два знака после запятой.
        Console.Write($"{matrix[i, j]:f2}\t");
      }
      // После окончания строки переходим на следующую строку для отображения данных в виде матрицы.
      Console.WriteLine();
    }
  }

  // Метод Main является точкой входа в программу.
  public static void Main(string[] args) {
    int m, n, minLimitRandom, maxLimitRandom;

    // Проверяем, были ли переданы аргументы командной строки (как альтернативу значениям по умолчанию).
    if (args.Length >= 4) {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      // Создаем матрицу с заданными параметрами.
      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

      // Выбираем случайные индексы трех элементов матрицы array.
      int row1 = new Random().Next(0, m);
      int col1 = new Random().Next(0, n);
      int row2 = new Random().Next(0, m);
      int col2 = new Random().Next(0, n);
      int row3 = new Random().Next(0, m);
      int col3 = new Random().Next(0, n);

      // Проверяем, являются ли выбранные элементы дробными числами.
      bool isFractional1 = (array[row1, col1] % 1) != 0;
      bool isFractional2 = (array[row2, col2] % 1) != 0;
      bool isFractional3 = (array[row3, col3] % 1) != 0;

      // Если два из трех выбранных элементов не являются дробными числами, выводим "Все ок!".
      if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3)) {
        Console.WriteLine("Все ок!");
      } else {
        // В противном случае выбрасываем исключение с сообщением.
        throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
      }
    } else {
      // Если аргументы командной строки не были переданы, устанавливаем значения по умолчанию.
      m = 3;
      n = 4;
      minLimitRandom = -10;
      maxLimitRandom = 10;

      // Создаем матрицу с параметрами по умолчанию и выводим ее на экран.
      double[,] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
    }
  }
}
Этот код определяет класс Answer, в котором есть два метода: CreateRandomMatrix для создания и заполнения двумерного массива случайными числами и PrintArray для вывода двумерного массива на консоль.
Также в методе Main определены команды для обработки аргументов командной строки и создания и вывода матрицы на основе введенных данных или значений по умолчанию.