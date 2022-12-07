// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
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

int Akkerman(int m, int n)
{
    if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    if (m == 0)
    {
        return n + 1;
    }
    return Akkerman(m, n);
}
Console.WriteLine("Результат = " + Akkerman(m, n));