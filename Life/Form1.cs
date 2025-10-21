using System;
using System.IO;
using System.Windows.Forms;

namespace Life
{
    public partial class Form1 : Form
    {
        string[] lines; // 存放文字檔每一行文字

        public Form1()
        {
            InitializeComponent();

            // 讀取文字檔內容
            string path = "生命靈數.txt";

            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path);
            }
            else
            {
                MessageBox.Show("找不到生命靈數.txt，請放在同資料夾!笨蛋!~~");
                lines = new string[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birth = dateTimePicker1.Value; // 取得生日日期

            int lifeNumber = GetLifeNumber(birth); // 計算生命靈數
            string starSign = GetStarSign(birth);  // 取得星座
            string message = FindMessage(starSign, lifeNumber); // 找到對應的文字內容

            // 顯示結果
            label3.Text = "你的星座是：" + starSign +
                          "\n你的生命靈數是：" + lifeNumber +
                          "\n\n" + message;
        }

        // 計算生命靈數（把生日數字加總，直到剩下一位數）
        private int GetLifeNumber(DateTime birth)
        {
            string birthday = birth.ToString("yyyyMMdd");
            int total = 0;

            // 把每個字元轉成數字相加
            for (int i = 0; i < birthday.Length; i++)
            {
                total += Convert.ToInt32(birthday[i].ToString());
            }

            // 若超過 9，繼續把數字拆開相加
            while (total >= 10)
            {
                int sum = 0;
                while (total > 0)
                {
                    sum += total % 10;
                    total = total / 10;
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
            else if ((m == 4 && d >= 20) || (m == 5 && d <= 20)) return "金牛座";
            else if ((m == 5 && d >= 21) || (m == 6 && d <= 20)) return "雙子座";
            else if ((m == 6 && d >= 21) || (m == 7 && d <= 22)) return "巨蟹座";
            else if ((m == 7 && d >= 23) || (m == 8 && d <= 22)) return "獅子座";
            else if ((m == 8 && d >= 23) || (m == 9 && d <= 22)) return "處女座";
            else if ((m == 9 && d >= 23) || (m == 10 && d <= 22)) return "天秤座";
            else if ((m == 10 && d >= 23) || (m == 11 && d <= 21)) return "天蠍座";
            else if ((m == 11 && d >= 22) || (m == 12 && d <= 21)) return "射手座";
            else if ((m == 12 && d >= 22) || (m == 1 && d <= 19)) return "摩羯座";
            else if ((m == 1 && d >= 20) || (m == 2 && d <= 18)) return "水瓶座";
            else return "雙魚座"; //其他星座寫完就剩下雙魚
        }

        // 從文字檔中找出對應的星座和生命靈數說明
        private string FindMessage(string starSign, int lifeNumber)
        {
            bool inThisStar = false;

            foreach (string line in lines)
            {
                // 找到星座段落開頭
                if (line.Contains(starSign))
                {
                    inThisStar = true;
                    continue;
                }

                // 在該星座區段中找到對應的生命靈數
                if (inThisStar && line.Contains("生命靈數" + lifeNumber + "："))
                {
                    int colonPos = line.IndexOf("：");
                    if (colonPos >= 0)
                    {
                        return line.Substring(colonPos + 1).Trim();
                    }
                }

                // 若遇到下一個星座區段就停止
                if (inThisStar && line.Contains("【"))
                {
                    break;
                }
            }

            return "找不到對應資料~你是怪人。";
        }
    }
}
