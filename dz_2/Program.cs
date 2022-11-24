/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число число: ");
int c = int.Parse(Console.ReadLine());

 int[] arr = {a,b,c};
 Array.Sort(arr);

if (arr.Length > 0) {
Console.WriteLine("Максимальное число " + arr[arr.Length - 1]);
}
