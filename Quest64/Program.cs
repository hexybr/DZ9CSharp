// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Задайте значение:");
int n;
if (!int.TryParse(Console.ReadLine()!, out n))
{
    Console.WriteLine("Неверный ввод");
    return;
}
int m = 1;
void ToOne(int n, int m)
{

    if (n > m)
    {
        ToOne(n, m + 1);
    }
    if (n > 1)
    {
        Console.Write(m + " ");
    }
    else
    {
        Console.Write(m);
    }
}

ToOne(n, m);