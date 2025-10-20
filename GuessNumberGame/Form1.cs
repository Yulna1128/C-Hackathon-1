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

        // �}�l�C��
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            answer = "";

            while (answer.Length < 4)
            {
                string num = rand.Next(0, 10).ToString();
                if (!answer.Contains(num)) // ������
                    answer += num;
            }

            listBox1.Items.Clear();
            txtGuess.Text = "";
            gameStarted = true;
            MessageBox.Show("�C���}�l�I�п�J�|�줣���ƪ��Ʀr�C");
        }

        // �ˬd����
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("�Х����}�l�C��~~~^^");
                return;
            }

            string guess = txtGuess.Text;

            if (guess.Length != 4)
            {
                MessageBox.Show("�п�J�|�ӼƦr~~~���i�H����!");
                return;
            }

            // �ˬd�O�_���Ʀr (�� TryParse ��²��)
            int test;
            if (!int.TryParse(guess, out test))
            {
                MessageBox.Show("�u���J�Ʀr�I");
                return;
            }

            string result = CheckAB(guess);
            listBox1.Items.Add(guess + " �� " + result);

            if (result == "4A0B")
            {
                MessageBox.Show("���ߧA����F�I�]�S���y");
                gameStarted = false;
            }

            txtGuess.Text = "";
        }

        // �p��A�MB
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

        // �ݵ���
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            if (gameStarted)
                MessageBox.Show("���׬O�G" + answer);
            else
                MessageBox.Show("�Х��}�l�C���I");
        }

        // ��󭫨�
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGuess.Text = "";
            listBox1.Items.Clear();
            answer = "";
            gameStarted = false;
        }
    }
}
