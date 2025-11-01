using System;
using System.Runtime.InteropServices;
using OfficeOpenXml;
using System.Windows.Forms;

namespace CapaIgu
{
    internal static class Program
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            //AllocConsole(); 


            ExcelPackage.License.SetNonCommercialPersonal("JhonFy");

            ApplicationConfiguration.Initialize();
            Application.Run(new AppRun());
        }
    }
}
