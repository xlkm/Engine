using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using mshtml;
using System.Threading;

namespace webLibrary
{
    public class Main
    {

        static string userNameID = "txtMemberNameCN";
        static string userNameID2 = "txtUserNameCN";
        static string passwordID = "txtPasswordCN";
        static string clickId = "Login_btnLoginCN";
        static string userName = "万礼聚诚";
        static string userName2 = "wljc457";
        static string password = "abc123";

        public static System.Windows.Forms.WebBrowser webBrowser;
        static System.Windows.Forms.Timer jsTimer = null;
        public static void test()
        {


            if (webBrowser == null)
                return;
            webBrowser.DocumentCompleted -= new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(s_DocumentCompleted);
            webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(s_DocumentCompleted);

            webBrowser.FileDownload -= new EventHandler(webBrowser_FileDownload);
            webBrowser.FileDownload += new EventHandler(webBrowser_FileDownload);

            jsHelper.Core.jsThread = new System.Threading.Thread(new System.Threading.ThreadStart(jsHelper.jsHtml.init));
            
            //jsHelper.Core.jsEvent = new System.Windows.Forms.MethodInvoker(startJS);
            //jsHelper.Core.jsThread.ApartmentState = ApartmentState.STA;
            jsHelper.Core.jsThread.SetApartmentState(ApartmentState.STA);
            jsHelper.Core.jsThread.Start();
            //GoToByUrl("http://ehire.51job.com/MainLogin.aspx");
            
            jsTimer = new System.Windows.Forms.Timer();
            jsTimer.Interval = 100;
            jsTimer.Tick += new EventHandler(jsTimer_Tick);
            jsTimer.Start();
        }

        static void webBrowser_FileDownload(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        static void jsTimer_Tick(object sender, EventArgs e)
        {
            startJsMethod();
        }

        public static void startJS()
        {
            if (jsHelper.Core.MethodName == "GoToByUrl")
            {
                GoToByUrl();
            }
        }

        public static void startJsMethod()
        {
            if (jsHelper.Core.MethodName!=null)
            switch (jsHelper.Core.MethodName)
            {
                case "GoToByUrl": GoToByUrl(); break;
                case "SetValueById": SetValueById(); break;
                case "SetValueByName": SetValueByName(); break;
                case "ClickByIdAndUpath": ClickByIdAndUpath(); break;
                case "ClickById": ClickById(); break;
            }
        }

        

        static void s_DocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url != webBrowser.Document.Url)
                return;
            startJsMethod();         
        }



        static void GoToByUrl()
        {
            webBrowser.Navigate(jsHelper.Core.MethodProperty[0].ToString());
            jsHelper.Core.MethodName = null;
            jsHelper.Core.MethodProperty = null;
            
        }

        static void SetValueById()
        {
            htmlHelperSimple hhs = new htmlHelperSimple(); 
            if (!hhs.init(webBrowser)) 
                return;
            if (hhs.setValueById(jsHelper.Core.MethodProperty[0].ToString(), jsHelper.Core.MethodProperty[1].ToString()))
            {
                jsHelper.Core.MethodName = null;
                jsHelper.Core.MethodProperty = null;
               
            }
                 
        }

        static void SetValueByName()
        {
            htmlHelperSimple hhs = new htmlHelperSimple();
            if (!hhs.init(webBrowser))
                return;
            if (hhs.setValueByName(jsHelper.Core.MethodProperty[0].ToString(), int.Parse(jsHelper.Core.MethodProperty[1].ToString()), jsHelper.Core.MethodProperty[2].ToString()))
            {
                jsHelper.Core.MethodName = null;
                jsHelper.Core.MethodProperty = null;
                
            }
        }

        static void ClickByIdAndUpath()
        {
            htmlHelperSimple hhs = new htmlHelperSimple();
            if (!hhs.init(webBrowser))
                return;
            if (hhs.clickElementByIdAndUpath(jsHelper.Core.MethodProperty[0].ToString(), jsHelper.Core.MethodProperty[1].ToString()))
            {
                jsHelper.Core.MethodName = null;
                jsHelper.Core.MethodProperty = null;
                
            }
            
        }

        static void ClickById()
        {
            
                htmlHelperSimple hhs = new htmlHelperSimple();
            if (!hhs.init(webBrowser))
                return;
            if (hhs.clickElementById(jsHelper.Core.MethodProperty[0].ToString()))
            {
                jsHelper.Core.MethodName = null;
                jsHelper.Core.MethodProperty = null;
               
            }
        }
    }
}
