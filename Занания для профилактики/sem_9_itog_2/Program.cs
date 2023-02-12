/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

using System;

class Akkerman {
    public static void Main (string[] args) {

        int InputNumber(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        int AkkermanFunction(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }  
                else if (n == 0 && m > 0)
                {
                    return AkkermanFunction(m - 1, 1);
                }
            else
            {
                return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
            }
        }

        int m = InputNumber("Введите M: ");
        int n = InputNumber("Введите N: ");
        int akkerman = AkkermanFunction(m, n);
        Console.Write($"Число M: {m}, Число N: {n}, Аккерман чисел M и N = {akkerman} ");
    
    }
}