Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);


int schet (int n)
{
if (n == 0)
    {
        return n;
    }
Console.Write($"{n} ");
return schet (n-1);
}

schet(n);