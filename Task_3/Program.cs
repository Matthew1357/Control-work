using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть значення n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть значення m:");
        int m = int.Parse(Console.ReadLine());

        int result = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                result++;
            }
        }

        Console.WriteLine($"Результат n * m: {result}");

        Console.ReadKey();
    }
}

