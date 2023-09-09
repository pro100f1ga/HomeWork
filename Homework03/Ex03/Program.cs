//Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

using System;
public class Answer
{
    static void ShowCube(int N)
    {
        if (N < 1)
        {
            Console.WriteLine("N должно быть положительным целым числом.");
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"Куб {i} равен {cube}");
        }
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}