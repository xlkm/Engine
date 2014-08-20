using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace htmlShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void start()
        {
            webLibrary.Main.webBrowser = this.webBrowser;
            webLibrary.Main.test();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start();
        }
    }
}
