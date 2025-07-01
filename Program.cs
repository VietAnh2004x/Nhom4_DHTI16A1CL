using System;
using System.Windows.Forms;
using DoAn1_Nhom4_DHTI16A1CL.Forms.MainForm;
namespace DoAn1_Nhom4_DHTI16A1CL
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
