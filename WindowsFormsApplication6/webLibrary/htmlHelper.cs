using System;
using System.Collections.Generic;
using System.Text;

namespace webLibrary
{
    public class htmlHelper
    {

        public static void setElementAttributeByIdThrow(mshtml.HTMLDocument htmlDocument, string Id, string attributeName, string value)
        {
            
            if (htmlDocument == null)
            {
                throw new Exception("传入的文档是空");
            }
            mshtml.IHTMLElement userNameElement = htmlDocument.getElementById(Id);
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        userNameElement = subDocument.getElementById(Id);
                        if (userNameElement != null)
                        {
                            userNameElement.setAttribute(attributeName, value, 0);
                            return;
                        }
                    }
                }
                //需带子窗体
                ;
                throw new Exception("未能找到该元素 id = " + Id);
                
            }
            userNameElement.setAttribute(attributeName, value, 0);
        }

        public static void setElementAttributeByNameThrow(mshtml.HTMLDocument htmlDocument, string elementName, int elementNumber, string attributeName, string value)
        {
            
            if (htmlDocument == null)
            {
                
                throw new Exception("传入的文档是空");
            }
            mshtml.IHTMLElement userNameElement = null;
            mshtml.IHTMLElementCollection ic = htmlDocument.getElementsByName(elementName);
            if (ic != null)
            {
                if (ic.length > elementNumber)
                {
                    userNameElement = ic.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                }
                
            }
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        mshtml.IHTMLElementCollection icc = subDocument.getElementsByName(elementName);
                        if (ic != null)
                        {
                            if (ic.length > elementNumber)
                            {
                                userNameElement = icc.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                                userNameElement.setAttribute(attributeName, value, 0);
                                return;
                            }
                        }                        
                    }
                }
                throw new Exception("未能找到该元素 elementName = " + elementName);
                
            }
            userNameElement.setAttribute(attributeName, value, 0);
        }

        public static void setElementAttributeByIdAndUPathThrow(mshtml.HTMLDocument htmlDocument, string uPath, string Id, string attributeName, string value)
        {

            if (htmlDocument == null)
            {
                throw new Exception("传入的文档是空");
            }
            mshtml.IHTMLElement userNameElement = htmlDocument.getElementById(Id);
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        userNameElement = subDocument.getElementById(Id);
                        if (userNameElement != null)
                        {
                            userNameElement = getElementFromeUpath(uPath, userNameElement);
                            if (userNameElement != null)
                            {   
                                userNameElement.setAttribute(attributeName, value, 0);
                            }
                            return;
                        }
                    }
                }
                //需带子窗体
                
                throw new Exception("未能找到该元素 id = " + Id);
                
            }

            userNameElement = getElementFromeUpath(uPath, userNameElement);
            if (userNameElement != null)
            {
                userNameElement.setAttribute(attributeName, value, 0);
            }
        }

        public static void setElementAttributeByNameAndUPathThrow(mshtml.HTMLDocument htmlDocument, string uPath, string elementName, int elementNumber, string attributeName, string value)
        {
            
            if (htmlDocument == null)
            {
                throw new Exception("传入的文档是空");
            }
            mshtml.IHTMLElement userNameElement = null;
            mshtml.IHTMLElementCollection ic = htmlDocument.getElementsByName(elementName);
            if (ic != null)
            {
                if (ic.length > elementNumber)
                {
                    userNameElement = ic.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                }

            }
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        mshtml.IHTMLElementCollection icc = subDocument.getElementsByName(elementName);
                        if (ic != null)
                        {
                            if (ic.length > elementNumber)
                            {
                                userNameElement = icc.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                                userNameElement = getElementFromeUpath(uPath, userNameElement);
                                if (userNameElement != null)
                                {
                                    userNameElement.setAttribute(attributeName, value, 0);
                                }                                
                                return;
                            }
                        }
                    }
                }

                throw new Exception("未能找到该元素 elementName = " + elementName);
               
            }
            userNameElement = getElementFromeUpath(uPath, userNameElement);
            if (userNameElement != null)
            {
                userNameElement.setAttribute(attributeName, value, 0);
            }   
        }

        public static void clickElementByIdThrow(mshtml.HTMLDocument htmlDocument, string Id)
        {
            
            if (htmlDocument == null)
            {
                throw new Exception("传入的文档是空");
            }
            mshtml.IHTMLElement userNameElement = htmlDocument.getElementById(Id);
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        userNameElement = subDocument.getElementById(Id);
                        if (userNameElement != null)
                        {
                            userNameElement.click();
                            return;
                        }
                    }
                }
                //需带子窗体
                ;
                throw new Exception("未能找到该元素 id = " + Id);

            }
            userNameElement.click();
        }

        public static void clickElementByNameThrow(mshtml.HTMLDocument htmlDocument, string elementName, int elementNumber)
        {

            if (htmlDocument == null)
            {

                throw new Exception("传入的文档是空");
            }
            mshtml.IHTMLElement userNameElement = null;
            mshtml.IHTMLElementCollection ic = htmlDocument.getElementsByName(elementName);
            if (ic != null)
            {
                if (ic.length > elementNumber)
                {
                    userNameElement = ic.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                }

            }
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        mshtml.IHTMLElementCollection icc = subDocument.getElementsByName(elementName);
                        if (ic != null)
                        {
                            if (ic.length > elementNumber)
                            {
                                userNameElement = icc.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                                userNameElement.click();
                                return;
                            }
                        }
                    }
                }
                throw new Exception("未能找到该元素 elementName = " + elementName);

            }
            userNameElement.click();
        }

        public static void clickElementAttributeByIdAndUPathThrow(mshtml.HTMLDocument htmlDocument, string uPath, string Id)
        {

            if (htmlDocument == null)
            {
                throw new Exception("传入的文档是空");
            }
            mshtml.IHTMLElement userNameElement = htmlDocument.getElementById(Id);
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        userNameElement = subDocument.getElementById(Id);
                        if (userNameElement != null)
                        {
                            userNameElement = getElementFromeUpath(uPath, userNameElement);
                            if (userNameElement != null)
                            {
                                userNameElement.click();
                            }
                            return;
                        }
                    }
                }
                //需带子窗体

                throw new Exception("未能找到该元素 id = " + Id);

            }

            userNameElement = getElementFromeUpath(uPath, userNameElement);
            if (userNameElement != null)
            {
                userNameElement.click();
            }
        }

        public static void clickElementAttributeByNameAndUPathThrow(mshtml.HTMLDocument htmlDocument, string uPath, string elementName, int elementNumber)
        {

            if (htmlDocument == null)
            {
                throw new Exception("传入的文档是空"); ;
            }
            mshtml.IHTMLElement userNameElement = null;
            mshtml.IHTMLElementCollection ic = htmlDocument.getElementsByName(elementName);
            if (ic != null)
            {
                if (ic.length > elementNumber)
                {
                    userNameElement = ic.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                }

            }
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        mshtml.IHTMLElementCollection icc = subDocument.getElementsByName(elementName);
                        if (ic != null)
                        {
                            if (ic.length > elementNumber)
                            {
                                userNameElement = icc.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                                userNameElement = getElementFromeUpath(uPath, userNameElement);
                                if (userNameElement != null)
                                {
                                    userNameElement.click();
                                }
                                return;
                            }
                        }
                    }
                }

                throw new Exception("未能找到该元素 elementName = " + elementName);

            }
            userNameElement = getElementFromeUpath(uPath, userNameElement);
            if (userNameElement != null)
            {
                userNameElement.click();
            }
        }

        public static bool setElementAttributeById(mshtml.HTMLDocument htmlDocument, string Id, string attributeName, string value)
        {
            
            if (htmlDocument == null)
            {
                return false;
            }
            mshtml.IHTMLElement userNameElement = htmlDocument.getElementById(Id);
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        userNameElement = subDocument.getElementById(Id);
                        if (userNameElement != null)
                        {
                            userNameElement.setAttribute(attributeName, value, 0);
                            return true;
                        }
                    }
                }
                return false;

            }
            userNameElement.setAttribute(attributeName, value, 0);
            return true;
        }

        public static bool setElementAttributeByName(mshtml.HTMLDocument htmlDocument, string elementName, int elementNumber, string attributeName, string value)
        {

            if (htmlDocument == null)
            {
                return false;
            }
            mshtml.IHTMLElement userNameElement = null;
            mshtml.IHTMLElementCollection ic = htmlDocument.getElementsByName(elementName);
            if (ic != null)
            {
                if (ic.length > elementNumber)
                {
                    userNameElement = ic.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                }

            }
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        if (docHtmlDocument2 == null)
                            return false;
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        mshtml.IHTMLElementCollection icc = subDocument.getElementsByName(elementName);
                        if (ic != null)
                        {
                            if (ic.length > elementNumber)
                            {
                                userNameElement = icc.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                                userNameElement.setAttribute(attributeName, value, 0);
                                return true;
                            }
                        }
                    }
                }
                return false;

            }
            userNameElement.setAttribute(attributeName, value, 0);
            return true;
        }

        public static bool setElementAttributeByIdAndUPath(mshtml.HTMLDocument htmlDocument, string uPath, string Id, string attributeName, string value)
        {

            if (htmlDocument == null)
            {
                return false;
            }
            mshtml.IHTMLElement userNameElement = htmlDocument.getElementById(Id);
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        userNameElement = subDocument.getElementById(Id);
                        if (userNameElement != null)
                        {
                            userNameElement = getElementFromeUpathNull(uPath, userNameElement);
                            if (userNameElement != null)
                            {
                                userNameElement.setAttribute(attributeName, value, 0);
                            }
                            return true;
                        }
                    }
                }
                //需带子窗体

                return false;

            }

            userNameElement = getElementFromeUpathNull(uPath, userNameElement);
            if (userNameElement != null)
            {
                userNameElement.setAttribute(attributeName, value, 0);
                return true;
            }
            return false;
        }

        public static bool setElementAttributeByNameAndUPath(mshtml.HTMLDocument htmlDocument, string uPath, string elementName, int elementNumber, string attributeName, string value)
        {

            if (htmlDocument == null)
            {
                return false;
            }
            mshtml.IHTMLElement userNameElement = null;
            mshtml.IHTMLElementCollection ic = htmlDocument.getElementsByName(elementName);
            if (ic != null)
            {
                if (ic.length > elementNumber)
                {
                    userNameElement = ic.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                }

            }
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        mshtml.IHTMLElementCollection icc = subDocument.getElementsByName(elementName);
                        if (ic != null)
                        {
                            if (ic.length > elementNumber)
                            {
                                userNameElement = icc.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                                userNameElement = getElementFromeUpathNull(uPath, userNameElement);
                                if (userNameElement != null)
                                {
                                    userNameElement.setAttribute(attributeName, value, 0);
                                }
                                return true;
                            }
                        }
                    }
                }

                return false;

            }
            userNameElement = getElementFromeUpathNull(uPath, userNameElement);
            if (userNameElement != null)
            {
                userNameElement.setAttribute(attributeName, value, 0);
                return true;
            }
            return false;
        }

        public static bool clickElementById(mshtml.HTMLDocument htmlDocument, string Id)
        {
            if (htmlDocument == null)
            {
                return false;
            }
            mshtml.IHTMLElement userNameElement = htmlDocument.getElementById(Id);
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        userNameElement = subDocument.getElementById(Id);
                        if (userNameElement != null)
                        {
                            userNameElement.click();
                            return true;
                        }
                    }
                }
                return false;
            }
            userNameElement.click();
            return true;
        }

        public static bool clickElementByName(mshtml.HTMLDocument htmlDocument, string elementName, int elementNumber)
        {

            if (htmlDocument == null)
            {
                return false;
            }
            mshtml.IHTMLElement userNameElement = null;
            mshtml.IHTMLElementCollection ic = htmlDocument.getElementsByName(elementName);
            if (ic != null)
            {
                if (ic.length > elementNumber)
                {
                    userNameElement = ic.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                }

            }
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        mshtml.IHTMLElementCollection icc = subDocument.getElementsByName(elementName);
                        if (ic != null)
                        {
                            if (ic.length > elementNumber)
                            {
                                userNameElement = icc.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                                userNameElement.click();
                                return true;
                            }
                        }
                    }
                }
                return false;

            }
            userNameElement.click();
            return true;
        }

        public static bool clickElementAttributeByIdAndUPath(mshtml.HTMLDocument htmlDocument, string uPath, string Id)
        {

            if (htmlDocument == null)
            {
                return false;
            }
            mshtml.IHTMLElement userNameElement = htmlDocument.getElementById(Id);
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        userNameElement = subDocument.getElementById(Id);
                        if (userNameElement != null)
                        {
                            userNameElement = getElementFromeUpath(uPath, userNameElement);
                            if (userNameElement != null)
                            {
                                userNameElement.click();
                            }
                            return true;
                        }
                    }
                }
                return false;

            }

            userNameElement = getElementFromeUpathNull(uPath, userNameElement);
            if (userNameElement != null)
            {
                userNameElement.click();
                return true;
            }
            return false;
        }

        public static bool clickElementAttributeByNameAndUPath(mshtml.HTMLDocument htmlDocument, string uPath, string elementName, int elementNumber)
        {

            if (htmlDocument == null)
            {
                return false;
            }
            mshtml.IHTMLElement userNameElement = null;
            mshtml.IHTMLElementCollection ic = htmlDocument.getElementsByName(elementName);
            if (ic != null)
            {
                if (ic.length > elementNumber)
                {
                    userNameElement = ic.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                }

            }
            if (userNameElement == null)
            {
                if (htmlDocument.frames.length > 0)
                {
                    for (int j = 0; j < htmlDocument.frames.length; j++)
                    {
                        object senderBox = (object)j;
                        mshtml.IHTMLDocument2 docHtmlDocument2 = CrossFrameIE.GetDocumentFromWindow(htmlDocument.frames.item(ref senderBox) as mshtml.IHTMLWindow2);
                        var subDocument = docHtmlDocument2 as mshtml.HTMLDocument;
                        mshtml.IHTMLElementCollection icc = subDocument.getElementsByName(elementName);
                        if (ic != null)
                        {
                            if (ic.length > elementNumber)
                            {
                                userNameElement = icc.item(elementNumber, elementNumber) as mshtml.IHTMLElement;
                                userNameElement = getElementFromeUpath(uPath, userNameElement);
                                if (userNameElement != null)
                                {
                                    userNameElement.click();
                                }
                                return true;
                            }
                        }
                    }
                }

                return false;

            }
            userNameElement = getElementFromeUpathNull(uPath, userNameElement);
            if (userNameElement != null)
            {
                userNameElement.click();
                return true;
            }
            return false;
        }



        public static mshtml.IHTMLElement getElementFromeUpath(string uPath, mshtml.IHTMLElement fromElement)
        {
            mshtml.IHTMLElement tempElementU = fromElement;
            string[] pathss = uPath.Split('-');

            foreach (string p in pathss)
            {

                if (p.IndexOf("U") >= 0)
                {
                    for (int i = 0; i < p.Length; i++)
                        tempElementU = tempElementU.parentElement;
                }
                else
                {
                    try
                    {
                        int n = Int32.Parse(p);

                        mshtml.IHTMLElement tryTempElement = (mshtml.IHTMLElement)(tempElementU.children as mshtml.IHTMLElementCollection).item(n, n);
                        if (tryTempElement != null)
                        {
                            while (tryTempElement.outerHTML.IndexOf("<!--") == 0)
                            {
                                n++;
                                if ((tempElementU.children as mshtml.IHTMLElementCollection).length > n)
                                {
                                    tryTempElement = (mshtml.IHTMLElement)(tempElementU.children as mshtml.IHTMLElementCollection).item(n, n);
                                }
                            }
                            tempElementU = tryTempElement;
                        }
                    }
                    catch
                    {
                        throw new Exception("uPath 有误 uPath = " + uPath);
                        //return null;
                    }
                }
            }
            return tempElementU;
        }

        public static mshtml.IHTMLElement getElementFromeUpathNull(string uPath, mshtml.IHTMLElement fromElement)
        {
            mshtml.IHTMLElement tempElementU = fromElement;
            string[] pathss = uPath.Split('-');

            foreach (string p in pathss)
            {

                if (p.IndexOf("U") >= 0)
                {
                    for (int i = 0; i < p.Length; i++)
                        tempElementU = tempElementU.parentElement;
                }
                else
                {
                    try
                    {
                        int n = Int32.Parse(p);

                        mshtml.IHTMLElement tryTempElement = (mshtml.IHTMLElement)(tempElementU.children as mshtml.IHTMLElementCollection).item(n, n);
                        if (tryTempElement != null)
                        {
                            while (tryTempElement.outerHTML.IndexOf("<!--") == 0)
                            {
                                n++;
                                if ((tempElementU.children as mshtml.IHTMLElementCollection).length > n)
                                {
                                    tryTempElement = (mshtml.IHTMLElement)(tempElementU.children as mshtml.IHTMLElementCollection).item(n, n);
                                }
                            }
                            tempElementU = tryTempElement;
                        }
                    }
                    catch
                    {
                        //throw new Exception("uPath 有误 uPath = " + uPath);
                        return null;
                    }
                }
            }
            return tempElementU;
        }
    }
}
