/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов, запрашивает данные(элементы массива) у пользователя и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

Console.Clear();
Console.Write("Введите 8 чисел разделанных запятой : ");
string? userMass = Console.ReadLine();

userMass = userMass + ","; 


string RemovingSpaces (string mass){
  string mass_new = "";
  for (int i = 0; i < mass.Length; i++)
  {
    if (mass[i] != ' ') 
    {
      mass_new += mass[i];
    }
  }
  return mass_new;
}


void Proverka (int  mass){

      if (mass == '0'||mass == '1'||mass == '2'
      ||mass == '3'||mass == '4'||mass == '5'||mass == '6'
      ||mass == '7'||mass == '8'||mass == '9'||mass == ','
      ||mass == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

      }
}


int[] Ret_mass(string mass_new){ 

  int[] mass_num = new int[1]; 

  int j =0;

  for (int i = 0; i < mass_new.Length; i++){
    string seriesNew1 = "";

    while (mass_new[i] != ',' && i < mass_new.Length){
      seriesNew1 += mass_new[i];
      Proverka(mass_new[i]);
      i++;
    }
    mass_num[j] = int.Parse(seriesNew1);
    if (i < mass_new.Length-1){
      mass_num = mass_num.Concat(new int[] {0}).ToArray();
    }
    j++;
  }
  return mass_num;
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string mass_new = RemovingSpaces(userMass);

int[] mass_num =  Ret_mass(mass_new);

PrintArry(mass_num);
