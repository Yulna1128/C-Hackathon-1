using System;
using System.IO;
using System.Windows.Forms;

namespace Life
{
    public partial class Form1 : Form
    {
        string[] lines; // 存文字檔每一行

        public Form1()
        {
            InitializeComponent();

            // 讀取文字檔
            string path = "生命靈數.txt";
            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path);
            }
            else
            {
                MessageBox.Show("找不到生命靈數.txt，請放在同資料夾！");
                lines = new string[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birth = dateTimePicker1.Value;

            int life = GetLifeNum(birth);
            string star = GetStar(birth);
            string message = SearchMessage(star, life);

            label3.Text = "你的星座是 " + star + "\n你的生命靈數是 " + life + "\n\n" + message;
        }

        private int GetLifeNum(DateTime birth)
        {
            string s = birth.ToString("yyyyMMdd");
            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                total += s[i] - '0';
            }

            while (total >= 10)
            {
                int temp = 0;
                while (total > 0)
                {
                    temp += total % 10;
                    total = total / 10;
                }
                total = temp;
            }

            return total;
        }

        private string GetStar(DateTime birth)
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
            return "雙魚座"; //如果上面都不是就是雙魚啦!
        }

        private string SearchMessage(string star, int life)
        {
            bool findStar = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                // 找到星座那一段（例如含有 獅子座）
                if (line.Contains(star))
                {
                    findStar = true;
                    continue;
                }

                // 找到「生命靈數X：」
                if (findStar && line.Contains("生命靈數" + life + "："))
                {
                    int p = line.IndexOf("：");
                    if (p >= 0)
                    {
                        return line.Substring(p + 1).Trim();
                    }
                }

                // 若又看到下一個【，代表進到下一個星座
                if (findStar && line.Contains("【"))
                {
                    break;
                }
            }

            return "找不到對應資料";
        }
    }
}
