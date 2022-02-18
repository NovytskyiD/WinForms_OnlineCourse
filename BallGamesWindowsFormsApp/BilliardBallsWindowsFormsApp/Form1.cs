using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BilliardBallsWindowsFormsApp
{
    public partial class Form1 : Form
    {
        private List<BilliardBall> balls = new List<BilliardBall>();
        private Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowVerticalLine();
            int leftBlueOfCenterCnt = 0;
            int rightBlueOfCenterCnt = 0;
            int leftRedOfCenterCnt = 0;
            int rightRedOfCenterCnt = 0;
            foreach (var ball in balls)
            {
                if (ball.OnTheLeftSide())
                {
                    if (ball.GetBrush() == Brushes.Blue)
                        {
                        leftBlueOfCenterCnt++;
                    }
                    else
                    {
                        leftRedOfCenterCnt++;
                    }
                }
                else if (ball.OnTheRightSide())
                {
                    if (ball.GetBrush()==Brushes.Blue)
                    {
                        rightBlueOfCenterCnt++;
                    }
                    else
                    {
                        rightRedOfCenterCnt++;
                    }
                }
                
            }

            if (leftBlueOfCenterCnt == leftRedOfCenterCnt && rightRedOfCenterCnt == rightBlueOfCenterCnt && leftBlueOfCenterCnt + leftRedOfCenterCnt == rightBlueOfCenterCnt + rightRedOfCenterCnt&& leftBlueOfCenterCnt + leftRedOfCenterCnt + rightBlueOfCenterCnt + rightRedOfCenterCnt == balls.Count)
            {
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
            }

        }

        private void ShowVerticalLine()
        {
            var graphics = CreateGraphics();
            graphics.DrawLine(Pens.Black, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var ball = new BilliardBall(this,Brushes.Blue);
                ball.Start();
                ball.OnHited += Ball_OnHited;
                balls.Add(ball);


                ball = new BilliardBall(this, Brushes.Red);
                ball.Start();
                ball.OnHited += Ball_OnHited2;
                balls.Add(ball);

            }
        
        }

        private void Ball_OnHited(object sender, HitEventArgs e)
        {
            switch(e.Side)
                {
                case Side.Left:
                    leftBlueLabel.Text = (Convert.ToInt32(leftBlueLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightBlueLabel.Text = (Convert.ToInt32(rightBlueLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downBlueLabel.Text = (Convert.ToInt32(downBlueLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topBlueLabel.Text = (Convert.ToInt32(topBlueLabel.Text) + 1).ToString();
                    break;

            }
        }

        private void Ball_OnHited2(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftRedLabel.Text = (Convert.ToInt32(leftRedLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightRedLabel.Text = (Convert.ToInt32(rightRedLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downRedLabel.Text = (Convert.ToInt32(downRedLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topRedLabel.Text = (Convert.ToInt32(topRedLabel.Text) + 1).ToString();
                    break;

            }
        }
    }
}
