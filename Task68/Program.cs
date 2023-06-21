Console.Clear();

int levi (int n, int m)
{
    if (n==0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return levi ( n - 1, 1);
    }
    else 
    {
        return levi (n-1, levi (n, m - 1));
    }
}

Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Значение функции Аккермана для заданных чисел - {levi(n,m)}");