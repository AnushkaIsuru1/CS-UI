        private void makeCell(Panel p, int w, string txt, Color bg)
        {            
            Label l = new Label();
            l.BackColor = bg;
            l.ForeColor = Color.FromArgb(175, 175, 175);
            l.AutoSize = false;
            l.Height = 40;
            l.Width = w;
            l.Dock = DockStyle.Left;
            l.Padding = new Padding(10, 0, 10, 0);
            l.TextAlign = ContentAlignment.MiddleLeft;
            if (w == 60) { l.TextAlign = ContentAlignment.MiddleCenter; }
            l.Text = txt;
            l.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            p.Controls.Add(l);
        }

        private void makeBtn(Panel p, Boolean t)
        {
            //Config Edit button
            Color bg = Color.FromArgb(45,45,45);
            Color hovwe = Color.FromArgb(70,70,70);
            Color active = Color.FromArgb(90,90,90);
            Color boader = Color.FromArgb(100,100,100);
            EventHandler e = new EventHandler(this.edit);
            int lef = 700;
            string txt = "EDIT";
            
            //Config Delete button
            if (t)
            {
                bg = Color.FromArgb(52,15,30);
                hovwe = Color.FromArgb(120,8,25);
                active = Color.FromArgb(150,8,25);
                boader = Color.FromArgb(120,10,26);
                e = new EventHandler(this.delete);
                lef = 780;
                txt = "DELETE";
            }

            Button b = new Button();
            b.Text = txt;
            b.BackColor = bg;
            b.FlatAppearance.MouseOverBackColor = hovwe;
            b.FlatAppearance.MouseDownBackColor = active;
            b.FlatAppearance.BorderColor = boader;
            b.Left = lef;
            b.Top = 4;
            b.Size = new Size(70, 32);
            b.FlatStyle = FlatStyle.Flat;
            b.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            b.ForeColor = Color.FromArgb(200, 200, 200);
            b.UseVisualStyleBackColor = false;
            b.Click += e;
            p.Controls.Add(b);
        }
        
        private void Addrow(Boolean tp, string id, string nm, string snm, string un, string addr )
        {
            Color bg = Color.FromArgb(40, 40, 40);
            if (tp) { bg = Color.FromArgb(32, 32, 32); }//Making Zebra style

            Panel p = new Panel();
            p.BackColor = bg;
            p.Dock = DockStyle.Top;
            p.Size = new Size(880, 40);
            
            tablBody.Controls.Add(p);
            
            makeBtn(p, true);//Add delete Button
            makeBtn(p, false);//Add Edit Button
            makeCell(p, 230, addr, bg);//Add Address
            makeCell(p, 145, un, bg);//Add User name
            makeCell(p, 125, snm, bg);//Add Sir name
            makeCell(p, 125,  nm, bg);//Add Name
            makeCell(p, 60, id, bg);//Add ID
        }

        private void tableWrite(string sql)
        {
            tablBody.Controls.Clear();
            MySqlConnection conn = mysqlCon();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            Boolean st = true;
            while (reader.Read())
            {
                Addrow(st, reader["id"].ToString(), reader["nm"].ToString(), reader["snm"].ToString(), reader["un"].ToString(), reader["addr"].ToString());
                st = !st;//Toggle row background
            }
            reader.Close();
            conn.Close();
        }