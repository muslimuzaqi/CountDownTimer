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
        int timeLeft = 60;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                minutLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer.Stop();
                minutLabel.Text = "Time is up!";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeLeft = 60;
            minutLabel.Text = timeLeft + " seconds";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 5;
            minutLabel.Text = timeLeft.ToString() + " Seconds";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            timeLeft = timeLeft + 5;
            minutLabel.Text = timeLeft.ToString() + " Seconds";
        }
    }
}
