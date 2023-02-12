/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
(НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК И МАССИВЫ)
645 -> 5

78 -> третьей цифры нет

326791 -> 6
*/

using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("Введи число: ");

      int n = Convert.ToInt32(Console.ReadLine());
      

        if (n >= 100){
          
          while (n >= 1000){
            n /= 10;
          }

        var r = n % 10;

        Console.WriteLine(r);
        }
        else {
          Console.WriteLine("Третьей цифры нет");
        }
    }
}