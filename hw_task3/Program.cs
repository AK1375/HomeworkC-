// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void FillArrayWithNumbers(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
}

void PrintArrayElemFromLastToFirst(int[] arr, int index = 0)
{
    if (index == arr.Length)
    {
        return;
    }

    PrintArrayElemFromLastToFirst(arr, index + 1);
    Console.Write($"{arr[index]} ");
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.Write("Задайте размерность массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrSize];
FillArrayWithNumbers(array, 1, 100);
Console.Write("Элементы массива с начала: ");
PrintArray(array);
Console.WriteLine();
Console.Write("Элементы массива с конца: ");
PrintArrayElemFromLastToFirst(array);
