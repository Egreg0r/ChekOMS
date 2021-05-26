using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace ChekOMS
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.IO.Directory.CreateDirectory(Application.StartupPath+"\\Temp");
            System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Temp\\Исходящие");
            if (!File.Exists(Application.StartupPath + "\\Temp\\Номер.txt"))
            {
                File.WriteAllText(Application.StartupPath + "\\Temp\\Номер.txt", DateTime.Today.ToString("yyMM") + "01");
            }
            Logger.InitLogger();

            Application.Run(new Check());
        }
    }
}
