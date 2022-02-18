using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            var results = UserResultStorage.GetResults();
            foreach (var result in results)
            {
                dataGridView1.Rows.Add(result.Name, result.Score);
            }

            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }
    }
}
