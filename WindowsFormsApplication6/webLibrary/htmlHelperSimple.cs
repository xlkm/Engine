using System;
using System.Collections.Generic;
using System.Text;

namespace webLibrary
{
    class htmlHelperSimple
    {
        mshtml.HTMLDocument htmlDocument;
        public bool init(System.Windows.Forms.WebBrowser webBrowser)
        {
            try
            {
                if (webBrowser == null)
                    return false;
                if (webBrowser.Document == null)
                    return false;
                htmlDocument = webBrowser.Document.DomDocument as mshtml.HTMLDocument;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool setValueById(string id, string value)
        {
            return htmlHelper.setElementAttributeById(htmlDocument, id, "value", value);
        }

        public bool setValueByName(string name, int number, string value)
        {
            return htmlHelper.setElementAttributeByName(htmlDocument, name, number, "value", value);
        }

        public bool clickElementByIdAndUpath(string id, string uPath)
        {
            return htmlHelper.clickElementAttributeByIdAndUPath(htmlDocument, uPath, id);
        }

        public bool clickElementById(string id)
        {
            return htmlHelper.clickElementById(htmlDocument, id);
        }
    }
}
