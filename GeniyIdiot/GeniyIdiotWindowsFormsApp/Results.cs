using GeniyIdiotClassLibrary;
using System;
using System.Data;
using System.Windows.Forms;


namespace GeniyIdiotWindowsFormsApp
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            var resultsList = UsersResultStorage.GetResults();
            foreach (var userResult in resultsList)
            {
                dataGridView1.Rows.Add(userResult.Name, userResult.Result, userResult.Diagnose);
            }
        }
    }
}
