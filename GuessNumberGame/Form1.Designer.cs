namespace GuessNumberGame
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
            btnStart = new Button();
            btnShowAnswer = new Button();
            lblInput = new Label();
            txtGuess = new TextBox();
            btnCheck = new Button();
            btnReset = new Button();
            lblHistory = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(30, 30);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 40);
            btnStart.TabIndex = 7;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnShowAnswer
            // 
            btnShowAnswer.Location = new Point(30, 80);
            btnShowAnswer.Name = "btnShowAnswer";
            btnShowAnswer.Size = new Size(150, 40);
            btnShowAnswer.TabIndex = 6;
            btnShowAnswer.Text = "看答案";
            btnShowAnswer.UseVisualStyleBackColor = true;
            btnShowAnswer.Click += btnShowAnswer_Click;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(30, 140);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(46, 23);
            lblInput.TabIndex = 5;
            lblInput.Text = "輸入";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(30, 165);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(150, 30);
            txtGuess.TabIndex = 4;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(30, 210);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(150, 40);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "檢查答案";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(30, 260);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 40);
            btnReset.TabIndex = 2;
            btnReset.Text = "放棄重來";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Location = new Point(220, 30);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(82, 23);
            lblHistory.TabIndex = 1;
            lblHistory.Text = "遊戲歷程";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(220, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 234);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 330);
            Controls.Add(listBox1);
            Controls.Add(lblHistory);
            Controls.Add(btnReset);
            Controls.Add(btnCheck);
            Controls.Add(txtGuess);
            Controls.Add(lblInput);
            Controls.Add(btnShowAnswer);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "1A2B 猜數字遊戲";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnStart;
        private Button btnShowAnswer;
        private Label lblInput;
        private TextBox txtGuess;
        private Button btnCheck;
        private Button btnReset;
        private Label lblHistory;
        private ListBox listBox1;
    }
}
