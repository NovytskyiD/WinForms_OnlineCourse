using BallsGamesClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BallsV2WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int cntBalls;
        List<RandomMoveBall> randomMoveBalls = new List<RandomMoveBall>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var randomMoveBall = new RandomMoveBall(this);
                randomMoveBalls.Add(randomMoveBall);
                randomMoveBall.Start();
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < randomMoveBalls.Count; i++)
            {
                
                if (randomMoveBalls[i].IsClickedOnBall(e.X,e.Y))
                {

                        cntBalls++;
                        ballsCntLabel.Text = cntBalls.ToString();
                        randomMoveBalls[i].Stop();
                        randomMoveBalls.RemoveAt(i);
                   
                }
            }
        }
    }
}
