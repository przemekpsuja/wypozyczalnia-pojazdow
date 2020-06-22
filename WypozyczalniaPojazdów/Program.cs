using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace WypozyczalniaPojazdów
{
    internal class Program : Form
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Run(new Form());
        }
    }
}