using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("請輸入一句英文句子：");
        string input = Console.ReadLine().ToLower(); // 轉小寫，避免大小寫差異

        // 以空白分割成單字陣列
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // 用 Dictionary 來統計每個單字的出現次數
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        // 輸出結果
        foreach (var item in wordCount)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}
