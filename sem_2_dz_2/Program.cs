/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
(НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК И МАССИВЫ)
645 -> 5

78 -> третьей цифры нет

326791 -> 6
*/

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num);

if (str.Length > 2){
  Console.WriteLine("Третья цифра: " + str[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}