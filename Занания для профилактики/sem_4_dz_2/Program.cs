/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
class Dz_27{
      static void Main()
    {
      Console.Clear();
      Console.Write("Эта программа складыввает цифры в числе!");
      Console.Write("Введите число N: ");
      int chislo = Convert.ToInt32(Console.ReadLine());
      int sumchislo = Sumchislo(chislo);
      Console.WriteLine("Сумма цифр в числе: " + sumchislo);
    }

    static int Sumchislo(int chislo){
    
    int counter = Convert.ToString(chislo).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = chislo - chislo % 10;
      result = result + (chislo - advance);
      chislo = chislo / 10;
    }
   return result;
  }
}