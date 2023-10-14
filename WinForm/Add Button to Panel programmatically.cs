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