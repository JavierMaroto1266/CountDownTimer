using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownTimer
{
    public partial class CountDownTimer : Form
    {
        public CountDownTimer()
        {
            InitializeComponent();
        }

        int timeleft = 60;


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeleft > 0)
            {
                timeleft = timeleft - 1;
                timerLabel.Text = timeleft + " Seconds";
               
            }
            else
            {
                timer.Stop();
                timerLabel.Text = "Time is Up";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeleft = 60;
            timerLabel.Text = timeleft + " Seconds";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            timeleft = timeleft + 5;
            timerLabel.Text = timeleft.ToString() + " Seconds";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            timeleft = timeleft - 5;
            timerLabel.Text = timeleft.ToString() + " Seconds";

        }
        private bool isFirstImage = true; // Start with the first image by default
        private bool isSecondImage = false; // Flag to track current background image

        private void changeBackgroundButton_Click(object sender, EventArgs e)
        {
            if (isFirstImage)
            {
                // Set background image to the second image
                this.BackgroundImage = new Bitmap(@"C:\Users\mjavih\Desktop\Codes\csharp project\CountDownTimer\Background1.png");
                isFirstImage = false;
                isSecondImage = true;
            }
            else if (isSecondImage)
            {
                // Set background image back to default
                this.BackgroundImage = null;
                isSecondImage = false;
            }
            else
            {
                // Set background image to the first image
                this.BackgroundImage = new Bitmap(@"C:\Users\mjavih\Desktop\Codes\csharp project\CountDownTimer\Background.png");
                isFirstImage = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customAmountButton_Click(object sender, EventArgs e)
        {
            int customTime;

            // Get user input from the customTimeTextBox control
            string userInput = customTimeTextBox.Text;

            // Try parsing the input to an integer representing seconds
            if (int.TryParse(userInput, out customTime) && customTime > 0)
            {
                // Valid input - update timer and label
                timeleft = customTime;
                timerLabel.Text = customTime.ToString() + " Seconds";
            }
            else
            {
                // Invalid input - show an error message
                MessageBox.Show("Please enter a valid starting time in seconds (positive number).");
            }
        }
    }
}
