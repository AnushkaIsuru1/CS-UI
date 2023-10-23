Boolean s = true;
            for(int i = 0; i< listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().ToLower() == textBox1.Text.Trim().ToLower())
                {
                    listBox1.SelectedIndex = i;
                    s = false;
                    break;
                }
            }