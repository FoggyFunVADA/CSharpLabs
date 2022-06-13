using System;
using System.Windows.Forms;

namespace EngineersView
{
    internal static class Lab4
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EngineersForm());
        }
    }
}
