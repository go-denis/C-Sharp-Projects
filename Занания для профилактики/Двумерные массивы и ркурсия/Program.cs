//Задаем двумерный массив
Console.Clear();
string[,] table = new string[2,5];
table[1,2] = "слово";

//Выводим массив на экран при помощи циклов, перебирая строки и столбцы
for (int rows = 0; rows < 2; rows++)
{
    for (int column = 0; column < 5; column++)
    {
        Console.WriteLine($"-{table[rows, column]}-");
    }
}
//---------------------------------------------------

//Вывод матрицы

int[,] matrix = new int[3,4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
//---------------------------------------------------

//Вывод матрицы с помощью метода
void PrintArray(int[,] mart){

for (int i = 0; i < mart.GetLength(0); i++)
{
    for (int j = 0; j < mart.GetLength(1); j++)
    {
        Console.Write($"{mart[i, j]} ");
    }
    Console.WriteLine();
}
}

Console.WriteLine();
Console.WriteLine();

int[,] matr = new int[5,4];
PrintArray(matr);
//---------------------------------------

//Опишем доп метод, который заполняет матрицу случайными числами

void FillArray(int[,] matr_gen){
    for (int i = 0; i < matr_gen.GetLength(0); i++)
    {
        for (int j = 0; j < matr_gen.GetLength(1); j++)
        {
            matr_gen[i,j] = new Random().Next(1,1000);
        }

    }
}

int[,] mat_gen = new int[3,4];

PrintArray(mat_gen);//Печатаем наш массив
FillArray(mat_gen); //Генерируем числа
Console.WriteLine();//Делаем отступ
PrintArray(mat_gen);//Печатаем готовый массив
//--------------------------------------------------------------
//Рекурсия
//Рекурсия - это функция, которая вызывает сама себя!
//--------------------------------------------------------------

//Рассчитаем факториал при помощи рекурсии

double Factorial(int n)
{
if (n==1) return 1;
else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
//--------------------------------------------------------------
//Рассчет чисел Фибоначи с помощью рекурсии

double Fibonachi(int n)
{
    if(n==1 || n==2) return 1;
    else return Fibonachi(n-1) + Fibonachi(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine(Fibonachi(i));
}
//--------------------------------------------------------------