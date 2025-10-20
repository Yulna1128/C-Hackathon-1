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
            label1.Text = "�п�J���ū� (�XC)�G";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "�п�J�ؤ�ū� (�XF)�G";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double value))
            {
                MessageBox.Show("�п�J���T���Ʀr�I");
                return;
            }

            if (radioButton1.Checked)
                label1.Text = $"���G�G{value}�XC = {(value * 9 / 5 + 32):F1}�XF";
            else if (radioButton2.Checked)
                label1.Text = $"���G�G{value}�XF = {((value - 32) * 5 / 9):F1}�XC";
            else
                MessageBox.Show("�Х�����ഫ��V�I");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "���G�G";
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
