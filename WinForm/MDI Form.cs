       Form1 f1 = new Form1();
        Form2 f2 = new Form2();

        private void FileMenu_Click(object sender, EventArgs e)
        {
            
            f1.MdiParent = this;
            f2.Visible = false;
            f1.Visible = true;
            f1.Show();
        }

        private void EditMenu_Click(object sender, EventArgs e)
        {

        }