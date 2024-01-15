using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть слово без пробілів:");
        string word = Console.ReadLine();

        int count = 0;
        Console.Write("Позиції букв 'і': ");

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'і' || word[i] == 'І')
            {
                count++;
                Console.Write($"{i + 1} ");
            }
        }

        Console.WriteLine($"\nКількість букв 'і': {count}");

        Console.ReadKey();
    }
}
