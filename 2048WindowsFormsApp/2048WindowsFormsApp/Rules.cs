using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void rulseOkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
