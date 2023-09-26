using System.Diagnostics;


//создаем объект
Stopwatch stopwatch = new Stopwatch();
//засекаем время начала операции
stopwatch.Start();
//выполняем какую-либо операцию
for (int i = 0; i < 10001; i++)
{
    Console.WriteLine(i);
}
//останавливаем счётчик
stopwatch.Stop();
//смотрим сколько миллисекунд было затрачено на выполнение
Console.WriteLine($"Было затрачено {stopwatch.ElapsedMilliseconds} миллисекунд");