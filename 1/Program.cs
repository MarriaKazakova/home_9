using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение N:");
        int N = int.Parse(Console.ReadLine());

        PrintNumbers(N);
    }

    static void PrintNumbers(int n)
    {
        if (n > 0)
        {
            Console.Write(n + " ");
            PrintNumbers(n - 1);
        }
    }
}
