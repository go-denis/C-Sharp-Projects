/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
НЕ ИСПОЛЬЗОВАТЬ Math.Pow
*/

class Dz_25{
      static void Main(string[] args)
    {
        Console.WriteLine("Привет! Это задача 25, введи два числа и первое будет возведено в степень второго");

        Console.WriteLine("Введите первое число:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(dz_25_run(a,b));
    }

    static int dz_25_run(int a, int b){

        int step = a;
        for (int i = 1; i < b; i++)
        {
           step = step * a;
        }

        return step;
    }
}