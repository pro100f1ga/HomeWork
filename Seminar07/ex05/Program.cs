﻿int[] nums = new int[0];

Console.WriteLine("Введите число для добавления в массив или слово 'stop' для завершения");
string input = Console.ReadLine()!;

while (input != "stop")
{
int num = int.Parse(input);
Array.Resize(ref nums, nums.Length + 1);
nums[nums.Length - 1] = num;
Console.WriteLine(String.Join(" ", nums));
Console.WriteLine("Введите число для добавления в массив или слово 'stop' для завершения");
input = Console.ReadLine()!;
}