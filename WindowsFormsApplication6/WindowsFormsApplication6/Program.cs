using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Idle += new EventHandler(Application_Idle);
            Application.Run();
        }

        static void Application_Idle(object sender, EventArgs e)
        {
            webLibrary.Main.test();
        }

        


    }


}
