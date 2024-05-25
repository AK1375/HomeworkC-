// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// m = 2, n = 3 -> A(m,n) = 29

int AckermanFunc(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AckermanFunc(n - 1, 1);
    }
    return AckermanFunc(n - 1, AckermanFunc(n, m - 1));
}

Console.WriteLine("Введите натуральое число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральое число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Результат выполнения функции Акермана: " + AckermanFunc(n,m));



