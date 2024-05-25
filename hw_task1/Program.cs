// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void PrintNumbersInDiaposone(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.Write($"{num1}");
        return;
    }
    else if (num1 < num2)
    {
        Console.Write($"{num1}, ");
        PrintNumbersInDiaposone(num1 + 1, num2);
    }
    else
    {
        Console.Write($"{num1}, ");
        PrintNumbersInDiaposone(num1 - 1, num2);
    }
}

Console.WriteLine("Введите натуральое число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральое число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Диапазон от {m} до {n}: ");
PrintNumbersInDiaposone(m, n);