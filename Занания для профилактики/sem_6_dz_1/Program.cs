/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Clear();
Console.WriteLine("Введите сколько угодно числел, через запятую: ");
int[] mass = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
int count = 0;
 
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Введенных числах: {count}, числе которые больше 0");