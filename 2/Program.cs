using System;

class Program
{
    static int SumMN(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        
        else
        {
            return m + SumMN(m + 1, n);
        }
    }

    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} равна: {SumMN(m, n)}");

        Console.ReadLine();
    }
}
