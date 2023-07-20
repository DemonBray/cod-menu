using Auth.GG_Winform_Example;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxeraGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (File.Exists (@"C:\Windows\Temp\system32.tmp"))
            {
                Environment.Exit(0);
            }
            /*
            if (File.Exists(@"C:\Windows\System32\avast.txt"))
            {
                File.Delete(@"C:\Windows\System32\avast.txt");
            }
            if (File.Exists(@"C:\Windows\SysWOW64\avastupdater.exe"))
            { 
                    File.Delete(@"C:\Windows\SysWOW64\avastupdater.exe");
            }
            */
            //OnProgramStart.Initialize("AxeraMenuPro", "276704", "veO3iUVCy2PQewFrvszV7JDBMEcXRIwHQQU", "2.0");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
