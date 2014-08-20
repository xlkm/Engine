using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace jsHelper
{
    public class Core
    {
        public static string MethodName = null;
        public static object[] MethodProperty = null;
        public static System.Threading.Thread jsThread = null;
        public static object returnValue;
        public static MethodInvoker jsEvent = null;
    }
}
