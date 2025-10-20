using System;

class Program
{
    static void Main()
    {
        Console.Write("請輸入一個大於 90 的整數 max：");
        int max = int.Parse(Console.ReadLine());

        for (int i = 1; i <= max; i++)
        {
            if (i % 15 == 0)
                Console.WriteLine("Dann");      // 同時被 3 和 5 整除
            else if (i % 3 == 0)
                Console.WriteLine("Build");     // 被 3 整除
            else if (i % 5 == 0)
                Console.WriteLine("School");    // 被 5 整除
            else
                Console.WriteLine(i);           // 其他數字
        }
    }
}
