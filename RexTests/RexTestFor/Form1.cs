using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RexTestFor
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.webBrowser1.ObjectForScripting = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Location = new System.Drawing.Point(0, 0);
            this.Hide();
            this.Left = -this.Width * 2;

            string path = Path.Combine(Application.StartupPath, "test.html");
            string value = null;
            
            using (StreamReader sr = new StreamReader(path))
            {
                value = sr.ReadToEnd();
            }
            this.webBrowser1.DocumentText = value;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
