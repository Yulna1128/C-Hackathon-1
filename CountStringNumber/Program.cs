using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("請輸入一句英文句子：");
        string input = Console.ReadLine().ToLower();
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string[] uniqueWords = new string[words.Length];
        int[] counts = new int[words.Length];
        int uniqueCount = 0;

        for (int i = 0; i < words.Length; i++)
        {
            string currentWord = words[i];
            bool found = false;

            for (int j = 0; j < uniqueCount; j++)
            {
                if (uniqueWords[j] == currentWord)
                {
                    counts[j]++;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                uniqueWords[uniqueCount] = currentWord;
                counts[uniqueCount] = 1;
                uniqueCount++;
            }
        }

        Console.WriteLine("\n統計結果：");
        for (int i = 0; i < uniqueCount; i++)
        {
            Console.WriteLine($"{uniqueWords[i]} : {counts[i]}");
        }
    }
}
