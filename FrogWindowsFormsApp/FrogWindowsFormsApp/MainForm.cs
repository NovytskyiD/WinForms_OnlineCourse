using System;
using System.Windows.Forms;

namespace FrogWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
            if (EndGame())
            {
                if (CanBeBetter(Convert.ToInt32(scoreLabel.Text)))
                {
                    MessageBox.Show("Вы справились за минимальное количество ходов");
                }
                else
                {
                    var result = MessageBox.Show("Можно лучше. Хотите попробовать еще раз?", "Конец игры", MessageBoxButtons.YesNo);
                    if (result==DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }

            }
        }

        private void Swap (PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;

            if (distance>2)
            {
                MessageBox.Show("Так нельзя!");
            }
            else

            {
                var location = clickedPicture.Location;

                clickedPicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;
                scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
            }
            
        }

        private bool EndGame()
        {
            if (leftPictureBox1.Location.X<550||rightPictureBox4.Location.X>330)
            {
                return false;
            }

            leftPictureBox1.Enabled = false;
            leftPictureBox2.Enabled = false;
            leftPictureBox3.Enabled = false;
            leftPictureBox4.Enabled = false;

            rightPictureBox1.Enabled = false;
            rightPictureBox2.Enabled = false;
            rightPictureBox3.Enabled = false;
            rightPictureBox4.Enabled = false;

            return true;
        }

        private bool CanBeBetter(int moves)
        {
            int minMoves = 24;
            if (moves== minMoves)
            {
                return true;
            }
            return false;
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут правила", "Правила");
        }

        private void начатьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
