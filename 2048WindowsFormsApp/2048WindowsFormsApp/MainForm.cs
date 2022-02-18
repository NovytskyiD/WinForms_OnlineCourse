using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int mapSize;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int bestScore;
        private List<int> labelsNumber=new List<int>();
        private readonly User user = new User();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SetNameMapSize();
            InitMap();
            GenerateNumber();
            UpdateScore();
            GetBestScore();
        }

        private void SetNameMapSize()
        {
            startForm startForm = new startForm();
            startForm.ShowDialog();
            user.Name = startForm.userNameTextBox.Text;
            


            if (startForm.mapSizeListBox.GetItemText(startForm.mapSizeListBox.SelectedItem)== "4х4")
            {
                mapSize = 4;
                this.Size = new Size(350, 425);
            }
            else if (startForm.mapSizeListBox.GetItemText(startForm.mapSizeListBox.SelectedItem) == "5х5")
            {
                mapSize = 5;
                this.Size = new Size(450, 500);
            }
            else if (startForm.mapSizeListBox.GetItemText(startForm.mapSizeListBox.SelectedItem) == "6х6")
            {
                mapSize = 6;
                this.Size = new Size (480, 600);
            }

        }

        private void GetBestScore()
        {
            var results = UserResultStorage.GetResults();
            if (results.Count==0)
            {
                bestScore = 0;
            }
            else
            {
                bestScore = results.Max(t => t.Score);
            }
            
            bestScoreLabel.Text = bestScore.ToString();
        }

        private void UpdateScore()
        {
            scoreLabel.Text = user.Score.ToString();
            if (user.Score>bestScore)
                {
                bestScoreLabel.Text = user.Score.ToString();
            }
        }

        private void InitMap()
        {
            labelsMap = new Label[mapSize,mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i,j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private List<int> GetLabelsNumber ()
        {
            var list = new List<int>();
            for (int i=0;i<mapSize*mapSize;i++)
            {
                list.Add(i);
            }
            return list;
        }

        private void GenerateNumber()
        {
            labelsNumber = GetLabelsNumber();
            int countLabels = labelsNumber.Count;
            bool notChanged = true;
            for (int i = 0; i < countLabels; i++)
            {
                var randomNumberLabel = labelsNumber[random.Next(labelsNumber.Count)];
                
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    if (random.Next(4)<3)
                    {
                        labelsMap[indexRow, indexColumn].Text = "2";
                    }
                    else
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";
                    }
                    
                    notChanged = false;
                    break;
                }
                labelsNumber.Remove(randomNumberLabel);
            }
            if (notChanged)
            {
                var result = MessageBox.Show("Игра окончена! Хотите начать сначала?", "Нет ходов",MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
                       
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = Color.FromArgb(204, 206, 63);
            label.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(70, 70);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = 10 + indexColumn * 76;
            int y = 70 + indexRow * 76;
            label.Location = new Point(x, y);
            label.TextChanged += Label_TextChanged;
            return label;


        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            switch (label.Text)
            {
                case "":
                    label.BackColor = Color.FromArgb(204, 206, 63);
                        break;
                case "2":
                    label.BackColor = Color.FromArgb(204, 166, 63);
                    break;
                case "4":
                    label.BackColor = Color.FromArgb(204, 156, 63);
                    break;
                case "8":
                    label.BackColor = Color.FromArgb(204, 146, 63);
                    break;
                case "16":
                    label.BackColor = Color.FromArgb(204, 136, 63);
                    break;
                case "32":
                    label.BackColor = Color.FromArgb(204, 126, 63);
                    break;
                case "64":
                    label.BackColor = Color.FromArgb(204, 116, 63);
                    break;
                case "128":
                    label.BackColor = Color.FromArgb(204, 106, 63);
                    break;
                case "256":
                    label.BackColor = Color.FromArgb(204, 96, 63);
                    break;
                case "512":
                    label.BackColor = Color.FromArgb(204, 86, 63);
                    break;
                case "1024":
                    label.BackColor = Color.FromArgb(204, 76, 63);
                    break;
                case "2048":
                    label.BackColor = Color.FromArgb(204, 66, 63);
                    break;
                default:
                    label.BackColor = Color.FromArgb(204, 56, 63);
                    break;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Right)
            {
                MoveRight();
                GenerateNumber();
                UpdateScore();
            }
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
                GenerateNumber();
                UpdateScore();

            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
                GenerateNumber();
                UpdateScore();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
                GenerateNumber();
                UpdateScore();
            }

            
        }

        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    user.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }


            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {

                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    user.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }


            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {

                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    user.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }


            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {

                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    user.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rulesForm = new Rules();
            rulesForm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserResultStorage.Append(user);
        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Results results = new Results();
            results.ShowDialog();
        }
    }
}
