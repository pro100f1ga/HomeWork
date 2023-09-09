//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThreeDigit(string message)
{
    System.Console.Write(message); 
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdDigit(int number)
{
   while (number>999)
    {
     number /=10;   
    }
    return number %10;
}

bool ValidateNumber (int number)
{
    if (number<100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;    
    }
    return true;
}
int number = ThreeDigit("Введите число: ");
if(ValidateNumber(number))
{
    System.Console.WriteLine(GetThirdDigit(number));
}