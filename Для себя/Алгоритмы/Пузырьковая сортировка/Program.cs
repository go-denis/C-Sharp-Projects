﻿

//Пузырьковая сортировка 
Console.WriteLine("Введите кол-во элементов массива: ");

int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Начальный массив: ["+string.Join(",", array)+"]");
Console.WriteLine();
//Количесто прохождений 
for(int i = 0; i< n; i ++)
{
    //Прохождение по массиву n-1 чтобы не вылетить за массив
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}