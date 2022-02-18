using BallsGamesClassLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaluteWindowsFormsApp
{
    public partial class SaluteAuto : Form
    {
        private static Random random = new Random();
        public SaluteAuto()
        {
            InitializeComponent();
        }

        private void SaluteAuto_Load(object sender, EventArgs e)
        {
            
        }

        private void MoveUpBall_TopReached(object sender, TopReachedEventArgs e)
        {
            for (int i = 0; i < random.Next(4, 10);i++)
            {
                Brush brush = new SolidBrush(Color.FromArgb((byte)random.Next(1, 255), (byte)random.Next(1, 255), (byte)random.Next(1, 233)));
                var salute = new SaluteBall(this, e.X, e.Y, brush);
                salute.Start();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var moveUpBall = new MoveUpBall(this, Brushes.Red);
            moveUpBall.TopReached += MoveUpBall_TopReached;
            moveUpBall.Start();
        }
    }
}
