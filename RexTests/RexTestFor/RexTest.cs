using System;
using System.Collections.Generic;
using System.Text;

namespace RexTestFor
{
    
    public class RexTest
    {
        //[STAThread]
        public void Test()
        {
            Form1 f1 = new Form1();

            

            
            f1.ShowInTaskbar = false;
            f1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;

            f1.Size = new System.Drawing.Size(new System.Drawing.Point(0,0));

            f1.ShowDialog();
            
            //System.Threading.Thread.Sleep(5000);
        }
    }
}
