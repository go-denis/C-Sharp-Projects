using static Sorts;
//Подготовка для заполнения массива
public static class Infrastructure
{
    public static int[] CreateArray(this int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
        .Select(item => Random.Shared.Next(min, max))
        .ToArray();
    }

    public static int[] PrintArray(this int[] array)
    {
        //Console.WriteLine($"[{String.Join(',', array)}]");
        //SortSelection(array);
        Console.WriteLine($"[{String.Join(',', array)}]");
        return array;
    }
}