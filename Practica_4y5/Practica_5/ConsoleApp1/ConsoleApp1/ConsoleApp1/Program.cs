using System;
using System.Windows.Forms;
using CajeroAutomatico; // Asegúrate de que este sea el nombre de tu proyecto de Forms

namespace ConsoleApp1
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}