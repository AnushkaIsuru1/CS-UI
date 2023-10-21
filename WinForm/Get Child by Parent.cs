        private string getRowId(object sender)
        {
            var b = sender as Button;
            Panel p =(Panel)b.Parent;
            Label l = (Label)p.GetChildAtPoint(new Point(5,5));
            return l.Text;
        }