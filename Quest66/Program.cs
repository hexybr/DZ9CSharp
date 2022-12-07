// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите первое значение:");
int m;
if (!int.TryParse(Console.ReadLine()!, out m))
{
    Console.WriteLine("Неверный ввод");
    return;
}

Console.WriteLine("Введите второе значение:");
int n;
if (!int.TryParse(Console.ReadLine()!, out n))
{
    Console.WriteLine("Неверный ввод");
    return;
}

if (n < m)
{
    Console.WriteLine("Неверный интервал");
    return;
}

int sum = m;
void SumInterval(int n, int m)
{
    if (n > m)
    {
        sum += n;
        SumInterval(n - 1, m);
    }
    if (m == n)
    {
        Console.Write(n + " ");
    }
    else
    {
        Console.Write(n + " ");
    }
}
SumInterval(n, m);
Console.WriteLine($"Сумма = {sum}");