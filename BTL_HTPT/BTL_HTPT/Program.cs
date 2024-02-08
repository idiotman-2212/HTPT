using System;
using System.Windows.Forms;

namespace BTL_HTPT
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDemoOwnerAndCopy());
        }
    }
}
