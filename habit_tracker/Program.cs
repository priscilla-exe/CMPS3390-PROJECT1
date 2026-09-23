using System;
using System.Windows.Forms;

namespace habitTrack
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new habitWindow());
        }
    }
}