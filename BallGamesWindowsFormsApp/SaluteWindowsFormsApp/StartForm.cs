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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void saluteClickButton_Click(object sender, EventArgs e)
        {
            var saluteClick = new SaluteClick();
            saluteClick.ShowDialog();
        }

        private void saluteAutoButton_Click(object sender, EventArgs e)
        {
            var saluteAuto = new SaluteAuto();
            saluteAuto.ShowDialog();
        }
    }
}
