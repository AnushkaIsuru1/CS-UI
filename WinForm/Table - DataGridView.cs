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

            table.Rows.Add(1, "One");
            table.Rows.Add(2, "Two");
            table.Rows.Add(2, "Two");
            table.Rows.Add(2, "Two");
            dataGridView.DataSource = table;

            //Button Column
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "EDIT";
            dataGridView.Columns.Add(btn);

            //Image Column
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "Image";
            //img.Image = Properties.Resources.1.png;
            dataGridView.Columns.Add(img);

            //CheckBox
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.HeaderText = "CheckBox";
            dataGridView.Columns.Add(checkbox);

            //LInk
            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Page Link";
            dataGridView.Columns.Add(link);

            DataGridViewComboBoxColumn comb = new DataGridViewComboBoxColumn();
            comb.HeaderText = "SDSD";
            comb.Items.Add("1");
            comb.Items.Add("2");
            comb.Items.Add("3");
            dataGridView.Columns.Add(comb);
            
        }
    }
}
