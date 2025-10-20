using System;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class Form1 : Form
    {
        string answer = "";
        bool gameStarted = false;

        public Form1()
        {
            InitializeComponent();
        }

        // 開始遊戲
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            answer = "";

            while (answer.Length < 4)
            {
                string num = rand.Next(0, 10).ToString();
                if (!answer.Contains(num)) // 不重複
                    answer += num;
            }

            listBox1.Items.Clear();
            txtGuess.Text = "";
            gameStarted = true;
            MessageBox.Show("遊戲開始！請輸入四位不重複的數字。");
        }

        // 檢查答案
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("請先按開始遊戲~~~^^");
                return;
            }

            string guess = txtGuess.Text;

            if (guess.Length != 4)
            {
                MessageBox.Show("請輸入四個數字~~~不可以重複!");
                return;
            }

            // 檢查是否為數字 (用 TryParse 最簡單)
            int test;
            if (!int.TryParse(guess, out test))
            {
                MessageBox.Show("只能輸入數字！");
                return;
            }

            string result = CheckAB(guess);
            listBox1.Items.Add(guess + " → " + result);

            if (result == "4A0B")
            {
                MessageBox.Show("恭喜你答對了！也沒獎勵");
                gameStarted = false;
            }

            txtGuess.Text = "";
        }

        // 計算A和B
        private string CheckAB(string guess)
        {
            int A = 0;
            int B = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (guess[i] == answer[j])
                    {
                        if (i == j)
                            A++;
                        else
                            B++;
                    }
                }
            }

            return A + "A" + B + "B";
        }

        // 看答案
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            if (gameStarted)
                MessageBox.Show("答案是：" + answer);
            else
                MessageBox.Show("請先開始遊戲！");
        }

        // 放棄重來
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGuess.Text = "";
            listBox1.Items.Clear();
            answer = "";
            gameStarted = false;
        }
    }
}
