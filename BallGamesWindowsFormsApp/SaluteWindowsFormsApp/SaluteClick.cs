using BallsGamesClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaluteWindowsFormsApp
{
    public partial class SaluteClick : Form
    {
        public SaluteClick()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var random = new Random();
            var count = random.Next(1,11);
            for (int i = 0; i < count; i++)
            {
                Brush brush = new SolidBrush(Color.FromArgb((byte)random.Next(1, 255),(byte)random.Next(1, 255), (byte)random.Next(1, 233)));
                var salute = new SaluteBall(this, e.X, e.Y,brush);
                salute.Start();
            }
            
        }
    }
}
