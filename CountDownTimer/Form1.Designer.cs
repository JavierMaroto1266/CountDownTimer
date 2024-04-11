namespace CountDownTimer
{
    partial class CountDownTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.changeBackgroundButton = new System.Windows.Forms.Button();
            this.customAmountButton = new System.Windows.Forms.Button();
            this.customTimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.BackColor = System.Drawing.Color.Black;
            this.topLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.topLabel.Location = new System.Drawing.Point(-1, -1);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(802, 79);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Count Down Timer";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(288, 81);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(99, 49);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.White;
            this.stopButton.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(411, 81);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(99, 49);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(288, 136);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(99, 49);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.Black;
            this.timerLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.timerLabel.Location = new System.Drawing.Point(-1, 276);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(802, 61);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "60 Seconds";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.White;
            this.plusButton.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(288, 395);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(99, 49);
            this.plusButton.TabIndex = 6;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.White;
            this.minusButton.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(411, 395);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(99, 49);
            this.minusButton.TabIndex = 7;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(411, 136);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 49);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeBackgroundButton
            // 
            this.changeBackgroundButton.BackColor = System.Drawing.Color.White;
            this.changeBackgroundButton.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBackgroundButton.Location = new System.Drawing.Point(288, 340);
            this.changeBackgroundButton.Name = "changeBackgroundButton";
            this.changeBackgroundButton.Size = new System.Drawing.Size(222, 49);
            this.changeBackgroundButton.TabIndex = 9;
            this.changeBackgroundButton.Text = "Change Background";
            this.changeBackgroundButton.UseVisualStyleBackColor = false;
            this.changeBackgroundButton.Click += new System.EventHandler(this.changeBackgroundButton_Click);
            // 
            // customAmountButton
            // 
            this.customAmountButton.BackColor = System.Drawing.Color.White;
            this.customAmountButton.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customAmountButton.Location = new System.Drawing.Point(288, 191);
            this.customAmountButton.Name = "customAmountButton";
            this.customAmountButton.Size = new System.Drawing.Size(222, 49);
            this.customAmountButton.TabIndex = 10;
            this.customAmountButton.Text = "Enter Custom Amount";
            this.customAmountButton.UseVisualStyleBackColor = false;
            this.customAmountButton.Click += new System.EventHandler(this.customAmountButton_Click);
            // 
            // customTimeTextBox
            // 
            this.customTimeTextBox.Location = new System.Drawing.Point(288, 247);
            this.customTimeTextBox.Name = "customTimeTextBox";
            this.customTimeTextBox.Size = new System.Drawing.Size(222, 26);
            this.customTimeTextBox.TabIndex = 11;
            // 
            // CountDownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customTimeTextBox);
            this.Controls.Add(this.customAmountButton);
            this.Controls.Add(this.changeBackgroundButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.topLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CountDownTimer";
            this.Text = "CountDownTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button changeBackgroundButton;
        private System.Windows.Forms.Button customAmountButton;
        private System.Windows.Forms.TextBox customTimeTextBox;
    }
}

