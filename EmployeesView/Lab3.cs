using System;
using System.Windows.Forms;

namespace EmployeesView
{
    internal static class Lab3
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DirectorsForm());
        }
    }
}
