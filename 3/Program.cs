using System;

class Program
{
    static int Ack(int m, int n)
    {
        if (m == 0)
            return n + 1;

        if (n == 0)
            return Ack(m - 1, 1);

        return Ack(m - 1, Ack(m, n - 1));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение m:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Результат функции Аккермана для ({m}, {n}): {Ack(m, n)}");

        Console.ReadLine();
    }
}
