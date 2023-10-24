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


