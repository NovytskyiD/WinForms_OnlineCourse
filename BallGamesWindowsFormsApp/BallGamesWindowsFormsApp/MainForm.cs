using BallsGamesClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<Ball> balls; 
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            balls = new List<Ball>();
            for (int i = 0; i < 10; i++)
            {
                var randomMoveBall = new RandomMoveBall(this);
                balls.Add(randomMoveBall);
                randomMoveBall.Start();

                var ball = new RandomSizeAndPointBall(this);
                balls.Add(ball);
                ball.Start();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cntBalls=0;
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Stop();
                if (balls[i].IsOnForm())
                {
                    cntBalls++;
                }
            }

            MessageBox.Show($"Шариков поймано - {cntBalls.ToString()}");
        }

       
    }
}
