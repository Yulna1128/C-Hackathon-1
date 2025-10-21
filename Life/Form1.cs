using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Life
{
    public partial class Form1 : Form
    {
        string[] lines; // 用來存放文字檔內容

        public Form1()
        {
            InitializeComponent();

            // 檔案路徑
            string path = Path.Combine(Application.StartupPath, "生命靈數.txt");

            // 讀取檔案內容 (UTF8避免亂碼)
            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path, Encoding.UTF8);
            }
            else
            {
                MessageBox.Show("找不到 生命靈數.txt，笨蛋沒同一資料夾！");
                lines = new string[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 取得生日
            DateTime birth = dateTimePicker1.Value;

            // 計算生命靈數
            int lifeNumber = GetLifeNumber(birth);

            // 判斷星座
            string starSign = GetStarSign(birth);

            // 找出對應內容
            string message = FindMessage(starSign, lifeNumber);

            // 顯示結果
            label3.Text = $"你的星座是：{starSign}\n你的生命靈數是：{lifeNumber}\n\n{message}";
        }

        // 計算生命靈數（加總生日數字直到剩一位數）
        private int GetLifeNumber(DateTime birth)
        {
            string s = birth.ToString("yyyyMMdd");
            int total = 0;

            foreach (char c in s)
            {
                total += c - '0'; // 字元轉成數字
            }

            while (total >= 10)
            {
                int sum = 0;
                while (total > 0)
                {
                    sum += total % 10;
                    total /= 10;
                }
                total = sum;
            }

            return total;
        }

        // 判斷星座
        private string GetStarSign(DateTime birth)
        {
            int m = birth.Month;
            int d = birth.Day;

            if ((m == 3 && d >= 21) || (m == 4 && d <= 19)) return "牡羊座";
            if ((m == 4 && d >= 20) || (m == 5 && d <= 20)) return "金牛座";
            if ((m == 5 && d >= 21) || (m == 6 && d <= 20)) return "雙子座";
            if ((m == 6 && d >= 21) || (m == 7 && d <= 22)) return "巨蟹座";
            if ((m == 7 && d >= 23) || (m == 8 && d <= 22)) return "獅子座";
            if ((m == 8 && d >= 23) || (m == 9 && d <= 22)) return "處女座";
            if ((m == 9 && d >= 23) || (m == 10 && d <= 22)) return "天秤座";
            if ((m == 10 && d >= 23) || (m == 11 && d <= 21)) return "天蠍座";
            if ((m == 11 && d >= 22) || (m == 12 && d <= 21)) return "射手座";
            if ((m == 12 && d >= 22) || (m == 1 && d <= 19)) return "摩羯座";
            if ((m == 1 && d >= 20) || (m == 2 && d <= 18)) return "水瓶座";
            return "雙魚座"; //剩下就雙魚
        }

        // 從文字檔找對應說明
        private string FindMessage(string starSign, int lifeNumber)
        {
            bool inThisStar = false;
            string key = $"生命靈數{lifeNumber}：";

            foreach (string line in lines)
            {
                // 找到星座段落
                if (line.Contains(starSign))
                {
                    inThisStar = true;
                    continue;
                }

                // 找到對應靈數
                if (inThisStar && line.Contains(key))
                {
                    int pos = line.IndexOf("：");
                    return line.Substring(pos + 1).Trim();
                }

                // 下一個星座就結束
                if (inThisStar && line.StartsWith("【"))
                {
                    break;
                }
            }

            return "找不到對應資料，你就是怪人拉～";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
