using System;
using System.Windows.Forms;

namespace PlaneView
{
    internal static class Lab1
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CreatePlane());
        }
    }
}
