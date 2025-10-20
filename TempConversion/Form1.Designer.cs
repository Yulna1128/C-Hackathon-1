namespace TempConversion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();

            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Size = new System.Drawing.Size(160, 80);
            this.groupBox1.Text = "轉換選項";
            // 
            // radioButton1
            // 
            this.radioButton1.Text = "攝氏轉華氏";
            this.radioButton1.Location = new System.Drawing.Point(10, 20);
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Text = "華氏轉攝氏";
            this.radioButton2.Location = new System.Drawing.Point(10, 45);
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 30);
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 70);
            this.label1.Text = "結果：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 100);
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.Text = "轉換";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 100);
            this.button2.Size = new System.Drawing.Size(60, 30);
            this.button2.Text = "清除";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 數字按鈕 (逐一建立)
            // 
            this.button3.Location = new System.Drawing.Point(200, 20);
            this.button3.Size = new System.Drawing.Size(40, 30);
            this.button3.Text = "1";
            this.button3.Click += new System.EventHandler(this.Number_Click);

            this.button4.Location = new System.Drawing.Point(245, 20);
            this.button4.Size = new System.Drawing.Size(40, 30);
            this.button4.Text = "2";
            this.button4.Click += new System.EventHandler(this.Number_Click);

            this.button5.Location = new System.Drawing.Point(290, 20);
            this.button5.Size = new System.Drawing.Size(40, 30);
            this.button5.Text = "3";
            this.button5.Click += new System.EventHandler(this.Number_Click);

            this.button6.Location = new System.Drawing.Point(200, 55);
            this.button6.Size = new System.Drawing.Size(40, 30);
            this.button6.Text = "4";
            this.button6.Click += new System.EventHandler(this.Number_Click);

            this.button7.Location = new System.Drawing.Point(245, 55);
            this.button7.Size = new System.Drawing.Size(40, 30);
            this.button7.Text = "5";
            this.button7.Click += new System.EventHandler(this.Number_Click);

            this.button8.Location = new System.Drawing.Point(290, 55);
            this.button8.Size = new System.Drawing.Size(40, 30);
            this.button8.Text = "6";
            this.button8.Click += new System.EventHandler(this.Number_Click);

            this.button9.Location = new System.Drawing.Point(200, 90);
            this.button9.Size = new System.Drawing.Size(40, 30);
            this.button9.Text = "7";
            this.button9.Click += new System.EventHandler(this.Number_Click);

            this.button10.Location = new System.Drawing.Point(245, 90);
            this.button10.Size = new System.Drawing.Size(40, 30);
            this.button10.Text = "8";
            this.button10.Click += new System.EventHandler(this.Number_Click);

            this.button11.Location = new System.Drawing.Point(290, 90);
            this.button11.Size = new System.Drawing.Size(40, 30);
            this.button11.Text = "9";
            this.button11.Click += new System.EventHandler(this.Number_Click);

            this.button12.Location = new System.Drawing.Point(200, 125);
            this.button12.Size = new System.Drawing.Size(40, 30);
            this.button12.Text = "0";
            this.button12.Click += new System.EventHandler(this.Number_Click);

            this.button13.Location = new System.Drawing.Point(245, 125);
            this.button13.Size = new System.Drawing.Size(40, 30);
            this.button13.Text = ".";
            this.button13.Click += new System.EventHandler(this.Number_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(520, 180);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Text = "攝氏華氏溫度轉換";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}
