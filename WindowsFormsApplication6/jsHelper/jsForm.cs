using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace jsHelper
{

    
    
    public partial class jsForm : Form
    {
        public jsForm()
        {
            InitializeComponent();
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
            this.webBrowser1.ObjectForScripting = new ServerJsToClient();
            
        }

        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //string a= this.webBrowser1.DocumentText;
            //throw new NotImplementedException();
        }

        internal void loadString(string p)
        {
            this.webBrowser1.DocumentText = p;
        }

        private void jsForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.Left = -this.Width * 2;
        }

        
    }
}
