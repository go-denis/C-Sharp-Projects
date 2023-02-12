/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;

class SumNaturalElements {
  public static void Main (string[] args) {
  
    int m = InputNumber("Введите M: ");
    int n = InputNumber("Введите N: ");
    int def = m;


int InputNumber(string input)
{
     Console.Write(input);
    int output = int.Parse(Console.ReadLine());
    return output;
 }

 void PrintNaturalSum(int m, int n, int sum)
 {
     sum = sum + n;
     if (n <= m)
    {
         Console.Write($" {sum} ");
         return;
     }
     PrintNaturalSum(m, n - 1, sum);

 }
 

 if (m > n)
 {
     m = n;
     n = def;
 }
 Console.Write($"Число M: {m}, Число N: {n} сумма натуральных элементов в промежутке от M до N =");
 PrintNaturalSum(m, n, def = 0);

  }
}