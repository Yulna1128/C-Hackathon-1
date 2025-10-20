using System;

class Program
{
    static void Main()
    {
        int max = 0; // 用來存放使用者輸入的數字

        // 數字大於 90 為止
        while (true)
        {
            Console.Write("請輸入一個大於 90 的整數 max：");
            string input = Console.ReadLine();

            bool success = int.TryParse(input, out max);

            if (success)
            {
                if (max > 90)
                {
                    // 符合條件就離開迴圈
                    break;
                }
                else
                {
                    Console.WriteLine("錯誤：請輸入一個大於 90 的整數。");
                }
            }
            else
            {
                Console.WriteLine("錯誤：請輸入正確的整數格式。");
            }
        }

        for (int i = 1; i <= max; i++)
        {
            if (i % 15 == 0)
            {
                Console.WriteLine("Dann"); 
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Build"); 
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("School"); 
            }
            else
            {
                Console.WriteLine(i); 
            }
        }
    }
}
