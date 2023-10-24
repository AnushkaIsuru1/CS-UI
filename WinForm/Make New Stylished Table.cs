        private void makeCell(Panel p, int w, string txt, Color bg)
        {            
            Label l = new Label();
            l.BackColor = bg;
            l.ForeColor = Color.FromArgb(175, 175, 175);
            l.AutoSize = false;
            l.Height = 40;
            l.Width = w;
            l.Dock = DockStyle.Left;

        }


