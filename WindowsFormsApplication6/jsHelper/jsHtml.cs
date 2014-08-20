using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace jsHelper
{
    public class jsHtml
    {
        static jsForm jsForm1 = null;
        
         static string getMotherHtml(string jsString)
        {
            string addString = "jsHelper.Resources.js.html";
            //}

            Assembly asm = Assembly.GetExecutingAssembly(); //---获取程序集

            Stream sm = asm.GetManifestResourceStream(addString);

            StreamReader sr = new StreamReader(sm);

            string value = sr.ReadToEnd();
            string fromString = "@@@@";
            value = value.Replace(fromString, jsString);
            /*
            int headBegin = value.IndexOf("<head>") + "<head>".Length;
            int headEnd = value.IndexOf("</head>");
            string headString = value.Substring(headBegin, headEnd - headBegin);

            int bodyBegin = value.IndexOf("<body>") + "<body>".Length;
            int bodyEnd = value.IndexOf("</body>");
            string bodyString = value.Substring(bodyBegin, bodyEnd - bodyBegin);

            mshtml.IHTMLElement header = html11.getElementsByTagName("head").item(0, 0) as mshtml.IHTMLElement;
            header.insertAdjacentHTML("afterBegin", headString);
            html11.body.insertAdjacentHTML("beforeEnd", bodyString);
            */
            sr.Close();
            return value;
        }

        public static void init()
        {
            jsForm1 = new jsForm();
            jsForm1.ShowInTaskbar = false;
            jsForm1.Left = -jsForm1.Width * 2;
            

            string jsPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "path.js");
            
            using (StreamReader sr = new StreamReader(jsPath))
            {
                string jsString = sr.ReadToEnd();
                jsForm1.loadString(getMotherHtml(jsString));
            }
            jsForm1.ShowDialog();
        }
    }
}
