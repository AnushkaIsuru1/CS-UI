        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            hideMessage();
            TextBox t = sender as TextBox;
            string s = t.Text;
            if (s != "")
            {
                tableWrite($"SELECT `id`, `nm`, `snm`, `un`, `addr` FROM `user` WHERE nm LIKE('{s}%') OR snm LIKE('{s}%') OR un LIKE('{s}%') OR addr LIKE('{s}%');");
            }
   
        }