using System;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "請輸入攝氏溫度 (°C)：";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "請輸入華氏溫度 (°F)：";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double value))
            {
                MessageBox.Show("請輸入正確的數字！");
                return;
            }

            if (radioButton1.Checked)
                label1.Text = $"結果：{value}°C = {(value * 9 / 5 + 32):F1}°F";
            else if (radioButton2.Checked)
                label1.Text = $"結果：{value}°F = {((value - 32) * 5 / 9):F1}°C";
            else
                MessageBox.Show("請先選擇轉換方向！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "結果：";
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void button3_Click(object sender, EventArgs e) => Number_Click(sender, e);
        private void button4_Click(object sender, EventArgs e) => Number_Click(sender, e);
        private void button5_Click(object sender, EventArgs e) => Number_Click(sender, e);
        private void button6_Click(object sender, EventArgs e) => Number_Click(sender, e);
        private void button7_Click(object sender, EventArgs e) => Number_Click(sender, e);
        private void button8_Click(object sender, EventArgs e) => Number_Click(sender, e);
        private void button9_Click(object sender, EventArgs e) => Number_Click(sender, e);
        private void button10_Click(object sender, EventArgs e) => Number_Click(sender, e);
        private void button11_Click(object sender, EventArgs e) => Number_Click(sender, e);
        private void button12_Click(object sender, EventArgs e) => Number_Click(sender, e);
        private void button13_Click(object sender, EventArgs e) => Number_Click(sender, e);
    }
}
