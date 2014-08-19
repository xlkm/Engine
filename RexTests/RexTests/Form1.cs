using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RexTests
{
    public partial class Form1 : Form
    {
        System.Threading.Thread testThread = null;
        public Form1()
        {
            InitializeComponent();
        }

        //[STAThread]
        private void Form1_Load(object sender, EventArgs e)
        {
            RexTestFor.RexTest rt = new RexTestFor.RexTest();

            //rt.Test();
            
            testThread = new System.Threading.Thread(new System.Threading.ThreadStart(rt.Test));
            this.webBrowser1.Navigate("http://www.baidu.com");

            //testThread.SetApartmentState(ApartmentState.MTA);

            try
            {
                testThread.SetApartmentState(ApartmentState.STA);
            }
            catch(Exception ee)
            {

            }

            //testThread.ThreadState = System.Threading.ThreadState
            testThread.Start();
             
        }


    }
}
