using System;

class Program
{
    static void Main()
    {
        // 稅率級距表
        decimal[] limits = { 540000, 1210000, 2420000, 4530000, 10310000 };
        decimal[] rates = { 0.05m, 0.12m, 0.20m, 0.30m, 0.40m, 0.50m };

        Console.Write("請輸入年收入: ");
        string input = Console.ReadLine()!;

        if (decimal.TryParse(input, out decimal income))
        {
            decimal tax = CalculateTax(income, limits, rates);
            Console.WriteLine($"應繳納稅額: {tax:N2}");
        }
        else
        {
            Console.WriteLine("輸入錯誤，請輸入正確的數字！");
        }

        Console.WriteLine("\n按任意鍵結束...");
        Console.ReadKey();
    }

    static decimal CalculateTax(decimal income, decimal[] limits, decimal[] rates)
    {
        decimal tax = 0;
        decimal previousLimit = 0;
        decimal currentLimit = 0;

        for (int i = 0; i < rates.Length; i++)
        {
            if (i < limits.Length)
            {
                currentLimit = limits[i];
            }
            else
            {
                currentLimit = income;
            }

            if (income > currentLimit)
            {
                tax += (currentLimit - previousLimit) * rates[i];
            }
            else
            {
                tax += (income - previousLimit) * rates[i];
                break;
            }

            previousLimit = currentLimit;
        }

        return tax;
    }
}
