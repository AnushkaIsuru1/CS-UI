using System;

using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Controls.Add
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();//For store data of Tablee
            DataGridView dataGridView = new DataGridView();// For show data of table
            dataGridView.Size = new Size(784, 250);
            panel1.Controls.Add(dataGridView);

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));



        }
    }
}
