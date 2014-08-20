using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        static Form1 f1;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            f1 = new Form1();
            //f1.Size = new System.Drawing.Size(0, 0);
            
            f1.Activated += new EventHandler(f1_Activated);
            Application.Run(f1);
        }

        static void f1_Activated(object sender, EventArgs e)
        {
            f1.Hide();
            f1.ShowInTaskbar = false;
            f1.Left = -f1.Width*2;
            f1.Show();
            f1.start();
        }
    }
}
