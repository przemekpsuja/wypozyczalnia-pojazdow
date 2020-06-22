using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace WypozyczalniaPojazdów
{
    internal class Program : Form
    {
        public Button B1;
        public DataGridView DataGrid;
        public Program()
        {
            DataGrid = new DataGridView();
            DataGrid.Size = new Size(300, 150);
            B1 = new Button();
            B1.Size = new Size(100, 40);
            B1.Location = new Point(50, 150);
            B1.Text = "Hej";
            Controls.Add(DataGrid);
            Controls.Add(B1);
        }

        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }
    }
}