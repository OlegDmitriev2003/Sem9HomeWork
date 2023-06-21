Console.Clear();
int summ = 0;


int sum (int a, int b)
{
        if (a == b)
    {
        summ = summ + a;
        return summ;
    }
summ = summ + a + b;
return sum (a + 1, b - 1);
}





Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a<b)
{
    sum (a, b);
}
else if (a>b)
{
    int temp = a;
    a = b;
    b = temp;
    sum (a, b);
}
Console.WriteLine($"Сумма натуральных чисел в промежутке между заданными числами - {summ}");