using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void saveUserNameButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text==string.Empty)
            {
                MessageBox.Show("Пожалуйста, введите имя");
            }
            else if (mapSizeListBox.SelectedItems.Count == 0)
                {
                MessageBox.Show("Пожалуйста, выберите размер поля");
                }
            else
            {
                Close();
            }
        }
    }
}
