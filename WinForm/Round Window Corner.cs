using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public partial class Form1 : Form
{
    public Form1()
    {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
    }

    [DllImport("Gdi32", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(
             int nLefetRect,
             int nToptRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
    );

}