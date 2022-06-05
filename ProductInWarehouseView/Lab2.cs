using System;
using System.Windows.Forms;

namespace ProductInWarehouseView
{
    internal static class Lab2
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CreateProducts());
        }
    }
}
