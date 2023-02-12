 /*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
 */
 
 class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPalindromicNumber(a));
    }
public static bool IsPalindromicNumber (int number)
    {
        if (number < 0)
        {
            throw new ArgumentException($"{number} число меньше нуля");
        }

        int numberTemp = number;

        int value;

        int numberRevers = 0;

        while (numberTemp > 0)
        {
            value = numberTemp % 10;
            numberRevers = numberRevers * 10 + value;
            numberTemp /= 10;
        }

        if (numberRevers == number)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}